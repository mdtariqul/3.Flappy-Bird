using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipecollector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.name == "cube2")
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.name == "cube2")
            Destroy(gameObject);
    }

}
