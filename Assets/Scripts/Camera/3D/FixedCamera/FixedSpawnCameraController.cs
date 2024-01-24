using System;
using System.Collections.Generic;
using UnityEngine;

public class FixedSpawnCameraController : MonoBehaviour
{

    public List<FixedCameraSpawnInfo> spawns;

    private Camera cam;

    void Start() {
        cam = GetComponent<Camera>();
    }

    public void SwitchCameraPosition(GameObject gameObject, bool forward)
    {
        FixedCameraSpawnInfo spawn = spawns.Find(x => x.spawnTrigger == gameObject);

        transform.SetPositionAndRotation(forward ? spawn.forwardSpawnPosition : spawn.backwardSpawnPosition, Quaternion.Euler(forward ? spawn.forwardSpawnRotation : spawn.backwardSpawnRotation));
        cam.fieldOfView = forward ? spawn.forwardFOV : spawn.backwardFOV;
    }

    [Serializable]
    public struct FixedCameraSpawnInfo {

        public GameObject spawnTrigger;

        public Vector3 forwardSpawnPosition;

        public Vector3 forwardSpawnRotation;

        public float forwardFOV;

        public Vector3 backwardSpawnPosition;

        public Vector3 backwardSpawnRotation;

        public float backwardFOV;

    }
}
