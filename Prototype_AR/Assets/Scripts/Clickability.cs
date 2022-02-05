using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickability : MonoBehaviour
{

    [SerializeField]
    private Camera arCamera;

    [SerializeField]
    private ClickedObject[] clickedObjects;

    [SerializeField]
    public Text Boxtext;

    [SerializeField]
    public GameObject panel;

    private Vector2 touchposition = default;

        public void deactivatePanel()
    { 
        for (int i = 0; i < panel.transform.childCount; i++)
        {
            var child = panel.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
        panel.SetActive(false);
    }

    public void activatePanel()
    {
        for (int i = 0; i < panel.transform.childCount; i++)
        {
            var child = panel.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(true);
        }
        panel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchposition = touch.position;

            if(touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObj;
                if(Physics.Raycast(ray,out hitObj))
                {
                    ClickedObject clickedObject = hitObj.transform.GetComponent<ClickedObject>();
                    if(clickedObject != null)
                    {
                        panel.SetActive(true);
                        Boxtext.text = clickedObject.ObjName + " Clicked";
                    }
                }
            }
        }
    }
}
