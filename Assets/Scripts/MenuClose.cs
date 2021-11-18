using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuClose : MonoBehaviour
{
    [SerializeField] private GameObject panel_Game1;
    void Start()
    {
        panel_Game1.SetActive(true);
    }

    public void Panel_Game1()
    {
        panel_Game1.SetActive(false);
    }
}
