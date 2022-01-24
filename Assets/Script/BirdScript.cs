using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{

    public static BirdScript instance;
    public Rigidbody2D bird;
    public Animator anim;
    private float forwardspeed = 3.0f;
    private float bouncespreed = 4.50f;
    private bool Isalive;
    public bool didflap;
    public AudioSource Button_Click;
    public AudioSource died;
    public GameObject pausePanel;
    public Text Scoretext;
    public Text HighScoretext;

    public GameObject brong;
    public GameObject silver;
    public GameObject gold;


    void Awake()
    {
        if (instance == null)
            instance = this;
        Isalive = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.Button_Click.Play();
            didflap = true;
        }
    }

    void FixedUpdate()
    {

        if (Isalive)
        {
            Vector3 tem = transform.position;
            tem.x += forwardspeed * Time.deltaTime;
            transform.position = tem;
            if (didflap)
            {
                didflap = false;
                bird.velocity = new Vector2(0, bouncespreed * 2);
                anim.SetTrigger("flap");

            }
        }
    }

    public void flap()
    {

        didflap = true;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "pipe")
        {
            if (Isalive)
            {
                Isalive = false;
                anim.SetTrigger("bird died");
                this.died.Play();
                pausePanel.SetActive(true);
                int s, h;
                s= ScoreController.instance.GetScore();
                h= ScoreController.instance.GethighScore();

                Scoretext.text = s.ToString();
                HighScoretext.text = h.ToString();

                if (s == h)
                {
                    gold.SetActive(true);
                }
                else if (s * 2 >= h)
                {
                    silver.SetActive(true);
                }
                else
                {
                    brong.SetActive(true);
                }







            }
        }
    }

    /* public int GethighScore()
      {
          int i = PlayerPrefs.GetInt("Highscore");
          return i;
      }
      public int GetScore()
      {
          int i = PlayerPrefs.GetInt("Score");
          return i;
      }*/
}
