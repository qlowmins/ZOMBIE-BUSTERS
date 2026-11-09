using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class enemyBossCollision : MonoBehaviour
{
    public int health = 100;
    public TMP_Text healthText;
    public int vesselCollected = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();
    }


    private void OnCollisionStay (Collision colEnemy)
    {
        if (colEnemy.gameObject.tag == "enemyBoss")
        {
            health -= 5;

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
            SceneManager.LoadScene("BossGameover");
        }

        if (vesselCollected == 2)
        {
            SceneManager.LoadScene("Winner");
        }
    }
}
