using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Management : MonoBehaviour
{
    public GameObject[] objects;
    public int act = -1;
    Control control;
    public int score = 0;
    public Text txt;
    public int fails = -2;
    public GameObject[] fails_t;
    public bool[] six = new bool[6] {false, false, false, false, false, false};
    bool once = true, once_f = true;
    public GameObject end;

    private void Start()
    {
        control = FindObjectOfType<Control>();
    }

    private void Update()
    {
        ActualUpdate();
    }

    public void End()
    {
        StartCoroutine(End_cor());
    }

    IEnumerator End_cor()
    {
        yield return new WaitForSeconds(0.5f);
        if (score >= PlayerPrefs.GetInt("high"))
        {
            PlayerPrefs.SetInt("high", score);
        }
        if (!PlayerPrefs.HasKey("ad"))
            PlayerPrefs.SetInt("ad", 0);
        else
        {
            int ad = PlayerPrefs.GetInt("ad");
            ad++;
            PlayerPrefs.SetInt("ad", ad);
        }
        if (PlayerPrefs.GetInt("ad") % 3 == 0)
        {
            AdsCore.ShowAdsVideo("Interstitial_Android");
        }
        transform.gameObject.SetActive(false);
        end.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ActualUpdate()
    {
        txt.text = score.ToString();
        if (act == 0)
        {
            if (once)
            {
                for (int i = 0; i < six.Length; i++)
                {
                    six[i] = false;
                    once = false;
                    once_f = true;
                }
            }
            if (control.top == true && control.left == true && Input.touchCount == 2)
            {
                score += 10;
                six[0] = true;
            }
        }
        if (act == 1)
        {
            if (once)
            {
                for (int i = 0; i < six.Length; i++)
                {
                    six[i] = false;
                    once = false;
                    once_f = true;
                }
            }
            if (control.top == true && control.right == true && Input.touchCount == 2)
            {
                score += 10;
                six[1] = true;
            }
        }
        if (act == 2)
        {
            if (once)
            {
                for (int i = 0; i < six.Length; i++)
                {
                    six[i] = false;
                    once = false;
                    once_f = true;
                }
            }
            if (control.left == true && control.right == true && Input.touchCount == 2)
            {
                score += 10;
                six[2] = true;
            }
        }
        if (act == 3)
        {
            if (once)
            {
                for (int i = 0; i < six.Length; i++)
                {
                    six[i] = false;
                    once = false;
                    once_f = true;
                }
            }
            if (control.top == true && control.bot == true && Input.touchCount == 2)
            {
                score += 10;
                six[3] = true;
            }
        }
        if (act == 4)
        {
            if (once)
            {
                for (int i = 0; i < six.Length; i++)
                {
                    six[i] = false;
                    once = false;
                    once_f = true;
                }
            }
            if (control.bot == true && control.left == true && Input.touchCount == 2)
            {
                score += 10;
                six[4] = true;
            }
        }
        if (act == 5)
        {
            if (once)
            {
                for (int i = 0; i < six.Length; i++)
                {
                    six[i] = false;
                    once = false;
                    once_f = true;
                }
            }
            if (control.bot == true && control.right == true && Input.touchCount == 2)
            {
                score += 10;
                six[5] = true;
            }
        }
        if (act == -1)
        {
            if (once_f)
            {
                once = true;
                int f = 0;
                for (int i = 0; i < six.Length; i++)
                {
                    if (six[i] == false)
                        f++;
                }
                if (f == 6)
                {
                    fails++;
                    if (fails >= 0 && fails < 2)
                        fails_t[fails].SetActive(true);
                }
                once_f = false;
            }
        }
        if (act == 6)
        {
            //
        }
        if (act == 7)
        {
            //
        }
        if (fails == 2)
        {
            End();
        }
        if (score >= PlayerPrefs.GetInt("high") && PlayerPrefs.HasKey("high"))
        {
            PlayerPrefs.SetInt("high", score);
        }
        else if (!PlayerPrefs.HasKey("high"))
        {
            PlayerPrefs.SetInt("high", score);
        }
    }

    public void NewGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
