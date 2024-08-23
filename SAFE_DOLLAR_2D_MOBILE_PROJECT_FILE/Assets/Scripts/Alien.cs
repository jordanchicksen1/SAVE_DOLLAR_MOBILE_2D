using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public Transform player;
    public float speed = 3.0f;

    void Update()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        //direction.y = 0;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
