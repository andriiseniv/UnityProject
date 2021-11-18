using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject panel_WIN;
    [SerializeField] private GameObject panel_LOOSE;

    [SerializeField] private UnityEngine.UI.Text TaskText;
    [SerializeField] private UnityEngine.UI.Image[] image;

    [SerializeField] public Sprite[] spriteGroup = new Sprite[16];

    [SerializeField] public int correctAnswers = 1;

    public UnityEngine.UI.Text CounerText;
    int countfromtext = 0;

    public UnityEngine.UI.Image[] hearts;
    public int hearts_count = 1;
    public UnityEngine.UI.Text FaultsText;
    public int faults = 0;

    public UnityEngine.UI.Text Panel_Result_Text;
    [SerializeField] private UnityEngine.UI.Text Panel_Result_Button_text;
    [SerializeField] private UnityEngine.UI.Text TimerEnabled;
    [SerializeField] private UnityEngine.UI.Text PanelEnabled;

   
    void Start()
    {
        panel_WIN.SetActive(false);
        panel_LOOSE.SetActive(false);
        GenerateBoard();
    }
    void Update()
    {
        countfromtext = int.Parse(CounerText.text);
        if (countfromtext == correctAnswers)
        {
            TimerEnabled.text = "1";
            PanelEnabled.text = "1";
            Debug.Log("You WON!!!");           
        }

        faults = int.Parse(FaultsText.text);
        if (hearts[faults].enabled == true)
        {
            hearts[faults].enabled = false;
            Debug.Log("Heart");
        }
         
        if (faults == hearts.Length-1)
        {
            Debug.Log("You LOSE!!!");
            TimerEnabled.text = "1";
            PanelEnabled.text = "0";
        }
    }


    private void GenerateBoard()
    {
         List<UnityEngine.UI.Image> picturesList = new List<UnityEngine.UI.Image>();
        for(int i = 0;i<image.Length;i++)
        {
            picturesList.Add(image[i]);
        }
       
        int correctImageIndex = 0;
        int[] correctImageIndexGroup = new int[picturesList.Count];

        for (int i = 0; i < correctAnswers; i++)
        {
            correctImageIndex = UnityEngine.Random.Range(correctImageIndex, picturesList.Count - 1);
            if(correctImageIndex== picturesList.Count - 2)
            {
                correctImageIndex = UnityEngine.Random.Range(0, picturesList.Count - 1);
            }
            while (correctImageIndexGroup[correctImageIndex] == 1)
            {
                correctImageIndex = UnityEngine.Random.Range(0, picturesList.Count - 1);
            }
            correctImageIndexGroup[correctImageIndex] = 1;
        }
  

        for (int i = 0; i < picturesList.Count; i++)
        {
            if (correctImageIndexGroup[i] == 1)
            {
                for (int k = 0; k < spriteGroup.Length; k++) 
                {
                    if(spriteGroup[k].name == TaskText.text)
                    {
                        picturesList[i].sprite = spriteGroup[k];
                    }
                }
            }
            else
            {
                picturesList[i] = RandomShape(picturesList[i], TaskText);
            }
        }
    }


    private UnityEngine.UI.Image RandomShape(UnityEngine.UI.Image randomImage, UnityEngine.UI.Text TaskText)
    {

        int id = UnityEngine.Random.Range(0, spriteGroup.Length);
        while (spriteGroup[id].name == TaskText.text)
        {
            id = UnityEngine.Random.Range(0, spriteGroup.Length);
        }
        randomImage.sprite = spriteGroup[id];
        return randomImage;
    }
}