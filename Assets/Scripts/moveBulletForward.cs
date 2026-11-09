using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBulletForward : MonoBehaviour
{
    // same as Animator

    Rigidbody bulletRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletRigidBody.AddForce(-transform.up * 150);
        Destroy(gameObject, .5f);
    }

    private void OnCollisionEnter(Collision bul)
    {
        if (bul.gameObject.tag == "enemy" || bul.gameObject.tag == "vessel" || bul.gameObject.tag == "enemyBoss")
        {
            Destroy(bul.gameObject);
            Destroy(gameObject);
        }
    }
}
