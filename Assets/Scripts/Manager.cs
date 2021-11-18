using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public UnityEngine.UI.Image im, im_black;
    Vector2 imInitialPos;
    bool complete = false;
    [SerializeField] private UnityEngine.UI.Text wintext;
    public void Start()
    {
        imInitialPos = im.transform.position;   
    }

    public void i_Drag()
    {
        if(wintext.enabled==true)
        {
            complete = true;
        }
        if (complete == false)
        {
            im.transform.position = Input.mousePosition;
        }
    }

    public void i_Drop()
    {
        float Distance = Vector3.Distance(im.transform.position, im_black.transform.position);
        if (Distance < 200)
        {
            im.transform.position = im_black.transform.position;
            complete = true;
            Color col = new Color(0.56f, 0.71f, 0.13f);
            im.color = col;
        }
        else
        {
            im.transform.position = imInitialPos;
        }
    }
}

