using UnityEngine;
using UnityEngine.EventSystems;

public class ModeSelectButton : MonoBehaviour, IPointerClickHandler
{
    public bool isDirectorButton;
    public ModeSwitcher modeSwitcher;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log($"{gameObject.name} clicked by pointer.");
        if (isDirectorButton)
            modeSwitcher.SwitchToDirector();
        else
            modeSwitcher.SwitchToAudience();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
