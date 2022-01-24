using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameSetBird : MonoBehaviour
{
    public static InGameSetBird instance;
           
    [SerializeField]
    public GameObject[] Gbirds;

    public void Start()
    {
        MakeInstance();

        if (GameController.instance.GetselectedBird() == 0)
        {
            Gbirds[0].SetActive(true);
        }
        else if (GameController.instance.GetselectedBird() == 1)
        {
            Gbirds[1].SetActive(true);
        }
        else
        {
            Gbirds[2].SetActive(true);
        }
    }

    public void playgame()
    {
        ScreenFader.instance.fadein("Game scene");
    }
    public void menu()
    {
        ScreenFader.instance.fadein("menu");
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
