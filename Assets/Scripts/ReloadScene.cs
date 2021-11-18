using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public float time;
    public int _sceneId;
    public UnityEngine.UI.Text timerText;

    void Update()
    {
        if(timerText.text=="Reload")
        {
            if (time >= 0)
            {
                time -= Time.deltaTime;             
            }
            else
            {
                SceneManager.LoadScene(_sceneId);
            }
        }         
    }
}
