using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    [SerializeField] private int[] SceneID_1;
    [SerializeField] private int[] SceneID_2;
    [SerializeField] private int[] SceneID_3;

    public void Load_Easy()
    {
        int scene_id = UnityEngine.Random.Range(0, SceneID_1.Length);
        SceneManager.LoadScene(SceneID_1[scene_id]);
    }

    public void Load_Medium()
    {
        int scene_id = UnityEngine.Random.Range(0, SceneID_2.Length);
        SceneManager.LoadScene(SceneID_2[scene_id]);
    }
    public void Load_Hard()
    {
        int scene_id = UnityEngine.Random.Range(0, SceneID_3.Length);
        SceneManager.LoadScene(SceneID_3[scene_id]);
    }
}
