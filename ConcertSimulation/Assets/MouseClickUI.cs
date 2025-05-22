using UnityEngine;

public class MouseClickUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red, 1f);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log("🔍 Hit: " + hit.collider.transform.root.name);
                // 여기에 모드 전환 호출
            }
            else Debug.Log("❌ Missed UI");
        }

        if (Input.GetKeyDown(KeyCode.U))
            Debug.Log("💡 U pressed");
    }
}
