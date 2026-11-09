using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // for the text
using UnityEngine.SceneManagement;

public class BossCollectItems : MonoBehaviour
{
    //visible in the inspector window
    public TMP_Text vesselText;

    int vesselCollected = 0;

    AudioSource vesselSFX;
    // Start is called before the first frame update
    void Start()
    {
        vesselSFX = GetComponent<AudioSource>();
        vesselText.text = vesselCollected.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (vesselCollected == 5)
        {
            SceneManager.LoadScene("Winner");
        }
    }

    private void OnCollisionEnter(Collision collectibles)
    {
        if (collectibles.gameObject.tag == "vessel"){
            
            Destroy(collectibles.gameObject);
            vesselSFX.Play();
            //inc by 1
            vesselCollected++;
            vesselText.text = vesselCollected.ToString();
        }
    }
}
