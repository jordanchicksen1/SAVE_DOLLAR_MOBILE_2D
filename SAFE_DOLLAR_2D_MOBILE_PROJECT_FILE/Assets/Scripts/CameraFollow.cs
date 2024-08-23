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
        // Follow the target on the X-axis only
        transform.position = new Vector3(thingToFollow.transform.position.x, transform.position.y, transform.position.z);
    }
}
