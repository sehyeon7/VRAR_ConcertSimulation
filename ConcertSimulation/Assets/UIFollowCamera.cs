using UnityEngine;

public class UIFollowCamera : MonoBehaviour

{
    public Transform targetCamera;
    public float distance = 1.0f;
    public float verticalOffset = 0.2f;
    public float horizontalOffset = -0.3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (targetCamera == null) return;

        Vector3 position = targetCamera.position + targetCamera.forward * distance;
        position += targetCamera.up * verticalOffset;
        position += targetCamera.right * horizontalOffset;

        transform.position = position;
        transform.rotation = targetCamera.rotation;

    }
}
