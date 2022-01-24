using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    private const string High_Score = "High Score ";
    private const string Selected_Bird = "Selected Bird";
    private const string Green_Bird = "Green Bird";
    private const string Red_bird = "Red Bird ";



    private void Awake()
    {
        MakeSingleton();
        IsthegameStartedFortheFristTime();
      //  PlayerPrefs.DeleteAll();
            

    }

    void MakeSingleton()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
    void IsthegameStartedFortheFristTime()
    {
        if (!PlayerPrefs.HasKey("IsthegameStartedFortheFristTime"))
        {
            PlayerPrefs.SetInt(High_Score, 0);
            PlayerPrefs.SetInt(Selected_Bird, 0);
            PlayerPrefs.SetInt(Green_Bird, 1);
            PlayerPrefs.SetInt(Red_bird, 1);
            PlayerPrefs.SetInt("IsthegameStartedFortheFristTime", 0);
            

        }
       
    }

    public void SetHighScore(int s)
    {
        PlayerPrefs.SetInt(High_Score, s);
    }

    public int gethighscore()
    {
       return PlayerPrefs.GetInt(High_Score);
    }

    public void SetSelectedBird(int s)
    {
        PlayerPrefs.SetInt(Selected_Bird, s);
    }

    public int GetselectedBird()
    {
       return PlayerPrefs.GetInt(Selected_Bird);
    }

    public void UnlockGreenBird()
    {
        PlayerPrefs.SetInt(Green_Bird, 1);
    }

    public int isgreenBirdUnlocked()
    {
        return PlayerPrefs.GetInt(Green_Bird);
    }

    public void UnlockredBird()
    {
        PlayerPrefs.SetInt(Red_bird, 1);
    }

    public int isredBirdUnlocked()
    {
        return PlayerPrefs.GetInt(Red_bird);
    }
}
