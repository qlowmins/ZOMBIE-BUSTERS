using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //Get the Animator component on this cube
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Press T to trigger the twist animation
        if (Input.GetKeyDown(KeyCode.T))
        {
            anim.SetTrigger("DoTwist");
        }
    }
}
