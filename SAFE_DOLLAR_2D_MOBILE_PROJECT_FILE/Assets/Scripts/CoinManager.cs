using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public float coins = 0f;
    public TextMeshProUGUI coinText;

    private void Start()
    {
        UpdateCoinText();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coin")
        {
            coins++;
            Destroy(other.gameObject);
            print("You collected a coin");
            UpdateCoinText();
        }
    }

    private void UpdateCoinText()
    {
        coinText.text = "Coins:" + coins.ToString();
    }
}
