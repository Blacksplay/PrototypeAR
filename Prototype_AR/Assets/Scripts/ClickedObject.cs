using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedObject : MonoBehaviour
{
    [SerializeField]
    public string ObjName;

    public float Health;

    public int ID;

    public bool hungry = true;

    public float changeovertime = 1;

    void Update()
    {
        if(Health<0)
        {
            Health = 0;
        }
        if (Health > 100)
        {
            Health = 100;
        }

        if (hungry)
        {
            hunger();
        }

    }


    private void hunger()
    {

        Health -= changeovertime * Time.deltaTime; 
    }
}
