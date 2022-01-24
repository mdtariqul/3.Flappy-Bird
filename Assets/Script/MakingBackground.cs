using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingBackground : MonoBehaviour
{
    public GameObject part;
    public Vector3 lastpart;
    public float offset =6.97f;

    void Awake()
    {
        InvokeRepeating("Creatnewpart", 6f, 2f);
    }

    public void Creatnewpart ()
    {

        Vector3 b = Vector3.zero;
        b = new Vector3(lastpart.x + offset, lastpart.y, lastpart.z);
        GameObject g = Instantiate(part, b, Quaternion.Euler(0, 0, 0));
        lastpart = g.transform.position;


    }
}
