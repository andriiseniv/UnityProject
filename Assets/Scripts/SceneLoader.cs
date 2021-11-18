using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void NextLevel(int _scenenumber)
    {
        SceneManager.LoadScene(_scenenumber);
    }
}
