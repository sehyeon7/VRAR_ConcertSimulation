using UnityEngine;

public class ModeSwitcher : MonoBehaviour
{
    public GameObject menuAudience;
    public GameObject menuDirector;
    public GameObject seat_UI;
    public GameObject duplicateMap;
    public GameObject player;

    private bool isAudienceMode = true;
    private bool isVisible = true;  


    public void EnableDuplicate()
    {
        duplicateMap.SetActive(true);
        Vector3 position = player.transform.position;
        Vector3 temp = new Vector3(0, 1.4f, -0.4f); 
        position += temp;
        duplicateMap.transform.position = position;
    }

    public void DisableDuplicate()
    {
        duplicateMap.SetActive(false);
    }

    public void SwitchToAudience()
    {
        isAudienceMode = true;
        if (isVisible)
        {
            menuAudience.SetActive(true);
            seat_UI.SetActive(true);
            menuDirector.SetActive(false);
        }
        DisableDuplicate();
    }

    public void SwitchToDirector()
    {
        Debug.Log("Director Mode Activated");
        isAudienceMode = false;
        if (isVisible)
        {
            menuAudience.SetActive(false);
            seat_UI.SetActive(false);
            menuDirector.SetActive(true);
        }
        EnableDuplicate();
    }

    public void SwitchToAudienceIfOn(bool isOn)
    {
        if (isOn)
            SwitchToAudience();
    }

    public void SwitchToDirectorIfOn(bool isOn)
    {
        if (isOn)
            SwitchToDirector();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isVisible = true;
        isAudienceMode = true;
        SwitchToAudience();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            isVisible = !isVisible;

            // 현재 모드에 따라 UI 표시 여부 조절
            if (isAudienceMode)
            {
                menuAudience.SetActive(isVisible);
                seat_UI.SetActive(isVisible);
                menuDirector.SetActive(false);
            }
            else
            {
                menuAudience.SetActive(false);
                seat_UI.SetActive(false);
                menuDirector.SetActive(isVisible);
            }

            // Duplicate Map은 Director 모드일 때만 반영
            duplicateMap.SetActive(!isAudienceMode);
        }
    }
}
