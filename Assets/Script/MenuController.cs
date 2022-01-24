using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static MenuController instance;
    [SerializeField]
    public GameObject[] birds;
    private bool IsgreenbirdUnlock,IsRedBirdUnlocked;



    private void Awake()
    {
        MakeInstance();
    }

    public void Start()
    {
        birds[GameController.instance.GetselectedBird()].SetActive(true);
        CheckBirdsareUnlocked();
    }

    void MakeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }



    void CheckBirdsareUnlocked()
    {
        
        if (GameController.instance.isredBirdUnlocked() == 1)
        {
            IsRedBirdUnlocked = true;
            
        }

        if (GameController.instance.isgreenBirdUnlocked() == 1)
        {
            IsgreenbirdUnlock = true;
           
        }
    }

    public void playgame()
    {
        ScreenFader.instance.fadein("Game scene");
    }
    public void detailsscene()
    {
        ScreenFader.instance.fadein("Details");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ChangeBird()
    {
        if (GameController.instance.GetselectedBird() == 0)
        {
            
            if (IsgreenbirdUnlock==true)
            {
               
                birds[0].SetActive(false);
                GameController.instance.SetSelectedBird(1);
                birds[GameController.instance.GetselectedBird()].SetActive(true);
            } 
        }
        else if (GameController.instance.GetselectedBird() == 1)
        {
            
            if (IsRedBirdUnlocked==true)
            {
                
                birds[1].SetActive(false);
                GameController.instance.SetSelectedBird(2);
                birds[GameController.instance.GetselectedBird()].SetActive(true);
            }
            else
            {
               
                birds[1].SetActive(false);
                GameController.instance.SetSelectedBird(0);
                birds[GameController.instance.GetselectedBird()].SetActive(true);
            }
        }
        else if (GameController.instance.GetselectedBird() == 2)
        {
          

            birds[2].SetActive(false);
            GameController.instance.SetSelectedBird(0);
            birds[GameController.instance.GetselectedBird()].SetActive(true);
        }
       

    }

}
