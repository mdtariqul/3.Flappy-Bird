using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class making_pipe : MonoBehaviour
{
    public GameObject part;
    public Vector3 lastpart;
    public float offset = 3.5f;
    public float y;


    void Awake()
    {
        InvokeRepeating("Creatnewpipepart", 1f, 1.08f);
    }

    public void Creatnewpipepart()
    {

        Vector3 b = Vector3.zero;
        b = new Vector3(lastpart.x + offset, lastpart.y, lastpart.z);
        y = Random.Range(3.16f, -.84f);
        b.y = y;
        GameObject g = Instantiate(part, b, Quaternion.Euler(0, 0, 0));
        lastpart = g.transform.position;


    }
}
