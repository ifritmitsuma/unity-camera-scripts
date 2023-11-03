using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ThirdPersonCameraScript : MonoBehaviour
{

    public GameObject player;

    public bool rotateWithPlayer = false;

    void Start() {
        Debug.Log("Third Person Camera active");
        if(player == null) {
            Debug.LogError("Must first set the player gameobject to follow");
        }
    }

    void FixedUpdate() {

        if(player == null) {
            return;
        }

        transform.position = player.transform.position;
        Vector3 target = Vector3.zero;
        target.x += 1.2f;
        target.y += 1.7f;
        target.z -= 1.5f;
        transform.Translate(target);

        if(rotateWithPlayer) {
            transform.rotation = new Quaternion(0, player.transform.rotation.y, 0, player.transform.rotation.w);
        }
        

    }

}
