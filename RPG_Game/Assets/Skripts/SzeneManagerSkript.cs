using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SzeneManagerSkript : MonoBehaviour
{

    //Statischer SzeneManagerSkript
    public static SzeneManagerSkript instance;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one SzeneManagerSkript in scene!");
            return;
        }
        instance = this;
    }




    // Use this for initialization
    void Start()
    {
        LoadSceneStart();
    }
     void Update()
    {
        
    }

    void LoadSceneStart()
    {
        if (false   )
        {
            Debug.Log("Playing Intro");

        }
        else if (true)
        {
            Debug.Log("Playing StartSzene");
            SceneManager.LoadScene(1);
        }
    }


}
