using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public float health = 10f;
    public TextMeshProUGUI healthText;

    private void Start()
    {
        UpdateHealthText();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "explosion")
        {
            health--;
            Destroy(other.gameObject);
            print("You Took Damage");
            UpdateHealthText();
        }

        if (other.tag == "Alien")
        {
            Destroy(gameObject);
            print("You Died");
        }
    }

    private void Update()
    {
        if(health == 0)
        {
            Destroy(gameObject);
            print("You Died");
        }
    }

    private void UpdateHealthText()
    {
        healthText.text = "Health: " + health.ToString(); 
    }
}
