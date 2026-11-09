using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class enemyCollision : MonoBehaviour
{
    public int health = 100;
    public TMP_Text healthText;
    public int vesselCollected = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();
    }

    private void OnCollisionEnter (Collision colEnemy)
    {
        if (colEnemy.gameObject.tag == "enemy")
        {
            health -= 5;

            if (health < 0)
            {
                health = 0;
            }

            healthText.text = health.ToString();
        }
    }

    private void OnCollisionStay (Collision colEnemy)
    {
        if (colEnemy.gameObject.tag == "enemy")
        {
            health -= 1;

            if (health < 0)
            {
                health = 0;
            }

            healthText.text = health.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            SceneManager.LoadScene("Gameover");
        }
    }
}
