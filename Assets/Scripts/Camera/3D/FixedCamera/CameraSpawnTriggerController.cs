using UnityEngine;

public class CameraSpawnTriggerController : MonoBehaviour
{

    public bool useParent;

    public FixedSpawnCameraController cameraController;

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            cameraController.SwitchCameraPosition(useParent ? transform.parent.gameObject : gameObject, other.transform.forward.z / transform.forward.z > 0);
        }
    }

}
