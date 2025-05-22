using UnityEngine;

public class ModeSwitcher : MonoBehaviour
{
    public GameObject menuAudience;
    public GameObject menuDirector;
    public GameObject duplicateMap;

    private bool isAudienceMode = true;
    private bool isVisible = true;  

    public void SwitchToAudience()
    {
        isAudienceMode = true;
        if (isVisible)
        {
            menuAudience.SetActive(true);
            menuDirector.SetActive(false);
        }
        duplicateMap.SetActive(false);
    }

    public void SwitchToDirector()
    {
        Debug.Log("Director Mode Activated");
        isAudienceMode = false;
        if (isVisible)
        {
            menuAudience.SetActive(false);
            menuDirector.SetActive(true);
        }
        duplicateMap.SetActive(true);
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
        if (Input.GetKeyDown(KeyCode.U))
        {
            isVisible = !isVisible;

            // 현재 모드에 따라 UI 표시 여부 조절
            if (isAudienceMode)
            {
                menuAudience.SetActive(isVisible);
                menuDirector.SetActive(false);
            }
            else
            {
                menuAudience.SetActive(false);
                menuDirector.SetActive(isVisible);
            }

            // Duplicate Map은 Director 모드일 때만 반영
            duplicateMap.SetActive(isVisible && !isAudienceMode);
        }
    }
}
