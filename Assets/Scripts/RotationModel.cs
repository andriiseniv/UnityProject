using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationModel : MonoBehaviour
{
    public GameObject[] model;
    public UnityEngine.UI.Text enabledText;
    public UnityEngine.UI.Text shapeID;
    public UnityEngine.UI.Text shapeButtonText;
    public GameObject panel_e;
    public int id;
    public float speed;
    public bool enabled;
    float PositionZ_Stock;
    float PositionZ;
    Quaternion rotatePos;
    Vector3 scale;

    void Start()
    {
        enabledText.text = 0.ToString();
        panel_e.active = false;
        scale = new Vector3(model[id].transform.localScale.x, model[id].transform.localScale.y, model[id].transform.localScale.z);
        rotatePos = model[id].transform.rotation;

        PositionZ = model[id].transform.position.z + 30f;
        PositionZ_Stock = model[id].transform.position.z;
        for(int i = 0;i<model.Length;i++)
        {
            model[id].transform.position = new Vector3(model[id].transform.position.x, model[id].transform.position.y, -1227f);
        }
    }


    void Update()
    {
        id = int.Parse(shapeID.text);
        if (enabled == true)
        {
            model[id].transform.Rotate(0f, 1f * speed, 0f);
            model[id].transform.localScale = scale;
        }
        else
        {    
            model[id].transform.localScale = new Vector3(model[id].transform.localScale.x, model[id].transform.localScale.y, 1f);
            Debug.Log(model[id].transform.rotation);
        }
    }

    public void EnableRotate()
    {
        id = int.Parse(shapeID.text);

        if (enabled==true)
        {
            enabledText.text = 0.ToString();
            shapeButtonText.text = "Плоска фiгура";
            panel_e.active = false;
            enabled = false;
            model[id].transform.SetPositionAndRotation(new Vector3(model[id].transform.position.x, model[id].transform.position.y, PositionZ_Stock), rotatePos);
        }
        else if(enabled==false)
        {
            enabledText.text = 1.ToString();
            shapeButtonText.text = "Об'емна фiгура";
            panel_e.active = true;
            enabled = true;
            model[id].transform.SetPositionAndRotation(new Vector3(model[id].transform.position.x, model[id].transform.position.y, PositionZ), rotatePos);

        }
    }
}
