using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;
    public Quaternion playerRotation; 
    public Vector3 offsetVector;

    void Start()
    {
        offsetVector = transform.position - player.position;
    }

    void Update()
    {
        playerRotation = player.transform.rotation; 
        Vector3 offsetRotated = playerRotation * offsetVector;

        transform.position = player.position + offsetRotated;
        transform.rotation = player.rotation;
    }
}


//https://docs.unity3d.com/ScriptReference/Transform.LookAt.html
//https://docs.unity3d.com/ScriptReference/Transform.LookAt.html
//https://stackoverflow.com/a/47904587
//