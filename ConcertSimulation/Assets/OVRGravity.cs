using UnityEngine;

public class OVRPlayerGravityMove : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float gravity = -9.81f;
    public Transform headTransform;  // CenterEyeAnchor

    private CharacterController controller;
    private Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 이동 방향 (헤드 기준)
        Vector2 input = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Vector2 buff = new Vector2(0, 0);
        if (input != buff)
        {
            Vector3 forward = headTransform.forward;
            Vector3 right = headTransform.right;
            forward.y = 0;
            right.y = 0;
            forward.Normalize();
            right.Normalize();

            Vector3 move = (forward * input.y + right * input.x) * moveSpeed;
            controller.Move(move * Time.deltaTime);

            // 중력 적용
            if (controller.isGrounded && velocity.y < 0)
            {
                velocity.y = -2f; // 지면에 고정
            }
            else
            {
                velocity.y += gravity * Time.deltaTime;
            }

            controller.Move(velocity * Time.deltaTime);
        }
    }
}
