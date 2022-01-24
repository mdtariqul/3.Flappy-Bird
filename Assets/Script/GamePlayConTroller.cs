using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GamePlayConTroller : MonoBehaviour
{
    public static GamePlayConTroller instance;

    [SerializeField]
    private Text scoretext, endscoretext, bestscoretext, gameovertext;

    [SerializeField]
    private Button restartButton, instractionButton;

    [SerializeField]
    private Sprite[] medals;

    [SerializeField]
    private Image medalimage;



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



}
