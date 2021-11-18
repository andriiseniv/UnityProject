using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_PanelShow : MonoBehaviour
{
    [SerializeField] private GameObject panel_Game1;
    [SerializeField] private GameObject panel_Game2;
    float time;
    void Start()
    {
        panel_Game1.SetActive(false);
        panel_Game2.SetActive(false);
    }

    public void Panel_Game1()
    {
        panel_Game1.SetActive(true);
    }

    public void Panel_Game2()
    {
        panel_Game2.SetActive(true);
    }

}
