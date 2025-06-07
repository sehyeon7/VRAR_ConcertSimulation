using UnityEngine;

public class UIFollowCamera : MonoBehaviour

{
    public Transform targetCamera;
    public float distance = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (targetCamera == null) return;

        transform.position = targetCamera.position + targetCamera.forward * distance;
        transform.rotation = targetCamera.rotation;

    }
}
