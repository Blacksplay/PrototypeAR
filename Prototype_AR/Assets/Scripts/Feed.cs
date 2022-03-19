using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{
    [SerializeField]
    public ClickedObject hungryGuy;

    public void FeedObject()
    {
        hungryGuy.Health += 10;
    }
}
