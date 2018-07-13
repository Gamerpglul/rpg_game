using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPlayers : MonoBehaviour {


    public GameObject[] Allplayers;
	// Use this for initialization
	void Start () {
       Allplayers = GameObject.FindGameObjectsWithTag("Player");
	}

}
