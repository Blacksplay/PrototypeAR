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

    public Sprite Herz_Rot;
    public Sprite Herz_Gelb;
    public Sprite Herz_Gruen;

    // Update is called once per frame
    void Update()
    {
        ProzentText.text = ((int)clickedObject.Health).ToString() + "%";

        if (clickedObject.Health< 25)
        { 
            Herz.GetComponent<Image>().sprite = Herz_Rot;
        }
        if (clickedObject.Health < 75 && clickedObject.Health > 25)
        {
            Herz.GetComponent<Image>().sprite = Herz_Gelb;
        }
        if (clickedObject.Health > 75)
        {
            Herz.GetComponent<Image>().sprite = Herz_Gruen;
        }

        if (FeedButton.GetComponent<Feed>().hungryGuy != clickedObject)
        {
            Boxtext.text = clickedObject.ObjName;
            FeedButton.GetComponent<Feed>().hungryGuy = clickedObject;
        }
    }
}
