using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenFader : MonoBehaviour
{

    public static ScreenFader instance;
    [SerializeField]
    private GameObject fadecanvas;

    [SerializeField]
    private Animator FadeAnim;

    void Awake()
    {
        MakeSingleton();

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

    public void fadein(string s)
    {
        StartCoroutine(FadeInAnimation(s));
       // fadeout();

    }

    public void fadeout()
    {
        StartCoroutine(FadeoutAnimation());
    }


    IEnumerator FadeInAnimation(string s)
    {
        fadecanvas.SetActive(true);
        FadeAnim.Play("ScreenFaderin");
        yield return new WaitForSeconds(.7f);
        SceneManager.LoadScene(s);
       

        fadeout();
    }

    IEnumerator FadeoutAnimation()
    {
       
        FadeAnim.Play("ScreenFaderout");
        yield return new WaitForSeconds(5f);
        fadecanvas.SetActive(false);
        


    }

}
