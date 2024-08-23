using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
     public GameObject thingToFollow;
    // this thing position (camera) should be the same as the car position. 
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 1, -10);
    }
}
