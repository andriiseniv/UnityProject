using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public float time;
    public UnityEngine.UI.Text wintext;
    public UnityEngine.UI.Text timerText;

    private float _roundedTime;

    [SerializeField] private GameObject panel_LOOSE;
    public UnityEngine.UI.Text Panel_Result_Text;
    [SerializeField] private UnityEngine.UI.Text Panel_Result_Button_text;

    Color col = new Color(0.71f, 0f, 0f);
   
    void Start()
    {
        panel_LOOSE.SetActive(false);
        timerText.text = time.ToString();
    }

   
    void Update()
    {
        if(wintext.text!="Перемога")
        {
            if (time >= 0 && wintext.enabled == false)
            {
                time -= Time.deltaTime;
                _roundedTime = Mathf.Round(time * 100.0f) / 100.0f;
                timerText.text = _roundedTime.ToString();

                if (time < 1.5f)
                {
                    Color col1 = new Color(0.90f, 0.28f, 0.20f);
                    timerText.color = col1;
                }
            }
            else
            {
                wintext.text = "Поразка";
                wintext.color = col;
                wintext.enabled = true;
                timerText.text = " ";

                panel_LOOSE.SetActive(true);
                Panel_Result_Text.color = col;
                Panel_Result_Text.text = "Поразка";
                Panel_Result_Button_text.text = "Заново";
            }
        }
    }
}
