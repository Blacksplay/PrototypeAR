using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{
    public ClickedObject clickedObject;

    private float count;

    public void FeedObject()
    {
        count = clickedObject.Health;
        count += 10;
        clickedObject.Health = count;
    }
}
