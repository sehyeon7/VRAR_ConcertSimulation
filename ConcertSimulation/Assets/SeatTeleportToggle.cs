using UnityEngine;
using UnityEngine.UI;

public class SeatTeleportToggle : MonoBehaviour
{
    [Header("이 토글 버튼 (자동 연결 가능)")]
    public Toggle seatToggle;

    [Header("대상: 이동시킬 오브젝트 (예: XR Origin)")]
    public Transform targetToMove;

    [Header("도착 지점: 이동할 위치 오브젝트")]
    public Transform teleportDestination;

    private void Start()
    {
        if (seatToggle == null)
            seatToggle = GetComponent<Toggle>();

        if (seatToggle != null)
            seatToggle.onValueChanged.AddListener(OnToggleChanged);
        else
            Debug.LogWarning($"{gameObject.name}에 Toggle 컴포넌트가 없습니다.");
    }

    private void OnToggleChanged(bool isOn)
    {
        if (isOn && targetToMove != null && teleportDestination != null)
        {
            targetToMove.position = teleportDestination.position;
        }
    }
}
