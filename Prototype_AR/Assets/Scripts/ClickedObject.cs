using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedObject : MonoBehaviour
{
    [SerializeField]
    public string ObjName;

    public double Health;

    public int ID;

    public bool hungry = true;

    public double changeovertime = 1;

    public Material Farbe;

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

        if (Health < 25)
        {
            Farbe.color = Color.red;
        }
        if (Health < 75 && Health > 25)
        {
            Farbe.color = Color.yellow;
        }
        if (Health > 75)
        {
            Farbe.color = Color.green;
        }
    }


    private void hunger()
    {

        Health -= changeovertime * Time.deltaTime;
    }
}
