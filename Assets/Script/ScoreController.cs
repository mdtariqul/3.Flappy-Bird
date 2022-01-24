using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;
    public int Score = 0;
    public Text Scoretext;
    public float HighScoretext;
    public AudioSource point;


    private void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.tag == "pipeholder")
        {
            this.point.Play();
            Score++;
            Scoretext.text =  Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            if (Score > GethighScore())
            {
                PlayerPrefs.SetInt("Highscore", Score);
                HighScoretext =  Score;
            }
          

        }
    }

    public int GethighScore()
    {
        int i = PlayerPrefs.GetInt("Highscore");
        return i;
    }
    public int GetScore()
    {
        int i = PlayerPrefs.GetInt("Score");
        return i;
    }

}
