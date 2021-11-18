using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSelection : MonoBehaviour
{
    public GameObject[] shapeDescription;
    public UnityEngine.UI.Text enabledText;
    public GameObject[] shapes;
    public int selectedShape = 0;
    public UnityEngine.UI.Text shapeID;
    int id;
    int enable;
    Quaternion rotatePos;
    float PositionZ;
    float PositionZ_Stock;
    private void Start()
    {
        int id = int.Parse(shapeID.text);
        for (int i = 0; i < shapes.Length; i++)
        {
            if(i!= id)
            {
                shapes[i].SetActive(false);
                shapeDescription[i].SetActive(false);
            }
        }
           
    }

    public void SetPosition()
    {
        rotatePos = shapes[id].transform.rotation;
        id = int.Parse(shapeID.text);
        enable = int.Parse(enabledText.text);
        PositionZ = shapes[id].transform.position.z + 30f;
        PositionZ_Stock = -1227f;

        if (enable == 1)
        {
            shapes[id].transform.SetPositionAndRotation(new Vector3(shapes[id].transform.position.x, shapes[id].transform.position.y, PositionZ_Stock), rotatePos);
        }
        else if (enable == 0)
        {
            shapes[id].transform.SetPositionAndRotation(new Vector3(shapes[id].transform.position.x, shapes[id].transform.position.y, PositionZ_Stock), rotatePos);
        }
    }


    public void NextShape()
    {
        for(int i = 0;i<shapes.Length;i++)
        {
            shapes[i].SetActive(false);
            shapeDescription[i].SetActive(false);
        }
          
        selectedShape = (selectedShape + 1) % shapes.Length;
        shapes[selectedShape].SetActive(true);
        shapeDescription[selectedShape].SetActive(true);
        shapeID.text = selectedShape.ToString();

        SetPosition();
    }

    public void PreviousShape()
    {
        for (int i = 0; i < shapes.Length; i++)
        {
            shapes[i].SetActive(false);
            shapeDescription[i].SetActive(false);
        }
        selectedShape--;
        if(selectedShape<0)
        {
            selectedShape += shapes.Length;
        }
        shapes[selectedShape].SetActive(true);
        shapeDescription[selectedShape].SetActive(true);
        shapeID.text = selectedShape.ToString();
        SetPosition();
    }
}
