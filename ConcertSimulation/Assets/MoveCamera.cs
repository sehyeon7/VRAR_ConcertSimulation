using UnityEngine;

public class OVRPlayerControllerSimple : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float rotationSpeed = 60.0f;
    public Transform cameraRig;  // OVRCameraRig
    public Transform headTransform; // CenterEyeAnchor

    void Update()
    {
        // 1. 이동 (왼쪽 조이스틱)
        Vector2 moveInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Vector3 forward = headTransform.forward;
        Vector3 right = headTransform.right;
        forward.y = 0; right.y = 0; // 수평 이동만
        forward.Normalize(); right.Normalize();

        Vector3 moveDirection = forward * moveInput.y + right * moveInput.x;
        cameraRig.position += moveDirection * moveSpeed * Time.deltaTime;

        // 2. 회전 (오른쪽 조이스틱)
        Vector2 rotateInput = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        float yaw = rotateInput.x * rotationSpeed * Time.deltaTime;
        cameraRig.Rotate(0, yaw, 0);  // y축 회전만
    }
}
