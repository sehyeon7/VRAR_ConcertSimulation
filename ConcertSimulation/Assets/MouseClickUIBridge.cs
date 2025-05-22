using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MouseClickUIBridge : MonoBehaviour
{
    public ModeSwitcher modeSwitcher;
    public Camera raycastCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("MouseClickUIBridge Started!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 클릭
        {
            if (Camera.main == null)
            {
                Debug.LogError("Camera.main is NULL!");
                return;
            }

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 2f);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log("Clicked on: " + hit.collider.gameObject.name);

                if (hit.collider.name.Contains("Audience"))
                {
                    modeSwitcher.SwitchToAudience();
                }
                else if (hit.collider.name.Contains("Director"))
                {
                    modeSwitcher.SwitchToDirector();
                }
            }
            else
            {
                Debug.LogWarning("Raycast did not hit anything.");
            }
        }
    }
}
