using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTR_Tasks : MonoBehaviour
{
    public Sprite[] sprites;
    public UnityEngine.UI.Text taskText;
    void Start()
    {
        int id = 0;
        for(int i = 0;i<sprites.Length;i++)
        {
            id = UnityEngine.Random.Range(0, sprites.Length);
        }
        taskText.text = sprites[id].name;
    }
}



