using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] public int n;

    [SerializeField] private UnityEngine.UI.Image[] image;
    [SerializeField] private UnityEngine.UI.Text wintext;
    [SerializeField] private UnityEngine.UI.Text timertext;


    [SerializeField] private GameObject panel_WIN;
    public UnityEngine.UI.Text Panel_Result_Text;
    [SerializeField] private UnityEngine.UI.Text Panel_Result_Button_text;




    Color col = new Color(0.56f, 0.71f, 0.13f);
    private int score = 0;
    void Start()
    {
        panel_WIN.SetActive(false);
        wintext.enabled = false;
    }

    void Update()
    {
        for(int i = 0;i<n;i++)
        {
            if (image[i].color == col) 
            {
                score++;
            }
            if(score ==n)
            {
                if(float.Parse(timertext.text) >0)
                {
                    Color col = new Color(0.53f, 0.87f, 0.45f);
                    wintext.text = "Перемога";
                    wintext.color = col;
                    wintext.enabled = true;
                    panel_WIN.SetActive(true);
                    Panel_Result_Text.color = col;
                    Panel_Result_Text.text = "Перемога";
                    Panel_Result_Button_text.text = "Далі";
                }
            }         
        }
        score = 0;
    }
}
