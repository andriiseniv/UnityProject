using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ClickableShape : MonoBehaviour,IPointerClickHandler
{  
    public UnityEngine.UI.Image randomImage;
    
    public Sprite s0;
    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
    public Sprite[] images;

    [SerializeField] public int stop = 1;
    int count = 0;
    public UnityEngine.UI.Text CounerText;
    public UnityEngine.UI.Text TaskText;
    int countfromtext = 0;
   
    public UnityEngine.UI.Text FaultsText;
    public int faults = 0;

    [SerializeField] public int FaultsToStop = 0;
    public int end_defeat = 0;

    [SerializeField] public int TrueToStop;
    public int end_win = 0;

    public void OnPointerClick(PointerEventData eventData)
    {
        end_defeat = int.Parse(FaultsText.text);
        end_win = int.Parse(CounerText.text);
        if (end_defeat == FaultsToStop|| end_win == TrueToStop)
        {
        }
        else
        {
            Debug.Log($"clicked {randomImage.sprite}");
            Debug.Log($"clicked {TaskText.text}");

            if (count == 1)
            {
            }
            else
            {
                if (randomImage.sprite.name == TaskText.text)
                {
                    count++;
                    Debug.Log($"clicked {count}");
                    Color col = new Color( 0.56f, 0.71f, 0.13f);
                    randomImage.color = col;
                    countfromtext = int.Parse(CounerText.text);
                    countfromtext += 1;
                    CounerText.text = countfromtext.ToString();
                }
                else
                {
                    faults = int.Parse(FaultsText.text);
                    faults++;
                    FaultsText.text = faults.ToString();
                    Color col = new Color(0.80f, 0.24f, 0.17f);
                    randomImage.color = col;
                }
            }
        }
    }
}
