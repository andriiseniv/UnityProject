using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    [SerializeField] public float time;
    public UnityEngine.UI.Text PanelTime;
    public UnityEngine.UI.Text TimerEnabled;
    public UnityEngine.UI.Text PanelEnabled;
    [SerializeField] private GameObject panel_WIN;
    [SerializeField] private GameObject panel_LOOSE;
    public bool on = false;
    
    void Update()
    {
        if (int.Parse(TimerEnabled.text) == 1)
        {
            on = true;
        }
        if (on ==true)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                PanelTime.text = time.ToString();
                if (time < 0.05f)
                {
                    if (int.Parse(PanelEnabled.text) == 1)
                    {
                        panel_WIN.SetActive(true);
                    }
                    if (int.Parse(PanelEnabled.text) == 0)
                    {
                        panel_LOOSE.SetActive(true);
                    }
                }
            }
        }
       
       
    }
}
