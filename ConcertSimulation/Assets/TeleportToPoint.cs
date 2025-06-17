using UnityEngine;

public class TeleportToPoint : MonoBehaviour
{
    public Transform cameraRig;         // OVRCameraRig(1)
    public Transform teleportTarget;    // TeleportPoint

    public void Teleport()
    {
        if (cameraRig != null && teleportTarget != null)
        {
            cameraRig.position = teleportTarget.position;
        }
    }
}
