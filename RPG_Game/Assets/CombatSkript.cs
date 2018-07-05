using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSkript : MonoBehaviour {

    //Reichweite
    public float Reichweite;
    //AngrifsRadius
    public float Angrifsradius;
    Vector3 centerOfPlayer;


    private void OnDrawGizmos()
    {
        centerOfPlayer = new Vector3(this.transform.position.x,this.transform.position.y+1,this.transform.position.z);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(centerOfPlayer, Reichweite);
        
    }
}
