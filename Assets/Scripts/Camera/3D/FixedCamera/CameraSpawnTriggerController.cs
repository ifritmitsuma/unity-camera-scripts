using UnityEngine;

public class CameraSpawnTriggerController : MonoBehaviour
{

    public FixedSpawnCameraController cameraController;

    void OnTriggerEnter(Collider other) {
        cameraController.SwitchCameraPosition(GetComponent<Collider>(), other.transform.forward.z / transform.forward.z > 0);
    }

}
