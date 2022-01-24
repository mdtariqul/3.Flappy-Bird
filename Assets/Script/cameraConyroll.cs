using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraConyroll : MonoBehaviour
{
    public static cameraConyroll instance;
    public Transform target;
    public Transform targetb;
    public Transform targetg;
    public Transform targetr;


    //  public float offset;
    public float x;
    public float y;
    public float z;

    public void Awake()
    {
        MakeInstance2();

        if (GameController.instance.GetselectedBird() == 0)
        {
            target = targetb;
        }
        else if (GameController.instance.GetselectedBird() == 1)
        {
            target = targetg;
        }
        else
        {
            target = targetr;
        }
    }



    void Update()
    {
       // offset = transform.position.x - target.position.x;
        x = target.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }

    private void LateUpdate()
    {

        transform.position = new Vector3(x , y , z);
    }

    void MakeInstance2()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

}
