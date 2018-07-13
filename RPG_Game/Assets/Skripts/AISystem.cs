using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISystem : MonoBehaviour
{

    bool IdelAktiv = false;
    bool FightAktiv = false;
    public float SpottingRange = 10f;

    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (IdelAktiv == true)
        {

        }
        else if (FightAktiv == true)
        {

        }
        else
        {
            WasZuTun();
        }
    }

    //Schauen Ob gegner in reichweite ist(Fight) oder nicht(Idel)
    void WasZuTun()
    {

    }

    void Idel()
    {

    }

    void Fight()
    {

    }
}
