using System;
using System.Collections.Generic;
using UnityEngine;

public class FixedSpawnCameraController : MonoBehaviour
{

    public List<FixedCameraSpawnInfo> spawns;


    public void SwitchCameraPosition(Collider collider, bool forward)
    {
        FixedCameraSpawnInfo spawn = spawns.Find(x => x.spawnTrigger == collider);

        transform.SetPositionAndRotation(forward ? spawn.forwardSpawnPosition : spawn.backwardSpawnPosition, Quaternion.Euler(forward ? spawn.forwardSpawnRotation : spawn.backwardSpawnRotation));
    }

    [Serializable]
    public struct FixedCameraSpawnInfo {

        public Collider spawnTrigger;

        public Vector3 forwardSpawnPosition;

        public Vector3 forwardSpawnRotation;

        public Vector3 backwardSpawnPosition;

        public Vector3 backwardSpawnRotation;

    }
}
