using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public float coins = 0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coin")
        {
            coins++;
            Destroy(other.gameObject);
            print("You collected a coin");
        }
    }
}
