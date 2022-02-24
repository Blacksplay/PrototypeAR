using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickedScreen : MonoBehaviour
{
    [SerializeField]
    public ClickedObject clickedObject;

    [SerializeField]
    public Text Boxtext;
   
    [SerializeField]
    public Text ProzentText;

    [SerializeField]
    public Button FeedButton;

    [SerializeField]
    public Image Herz;

    // Update is called once per frame
    void Update()
    {
        ProzentText.text = ((int)clickedObject.Health).ToString() + "%";

        if (clickedObject.Health< 25)
        { 
            Herz.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Herz_Spritesheet_0");
        }
        if (clickedObject.Health < 75 && clickedObject.Health > 25)
        {
            Herz.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Herz_Spritesheet_1");
        }
        if (clickedObject.Health > 75)
        {
            Herz.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Herz_Spritesheet_2");
        }

        if (FeedButton.GetComponent<Feed>().clickedObject != clickedObject)
        {
            Boxtext.text = clickedObject.ObjName;
            FeedButton.GetComponent<ClickedScreen>().clickedObject = clickedObject;
        }
    }
}
