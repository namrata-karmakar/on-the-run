using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ScoreSystem : MonoBehaviour
{
    public int points;
    private PlayerMovement pm;
    void Start()
    {
        points = 0;
        pm = this.GetComponent<PlayerMovement>();
    }   

    private void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Fruit"){
            points++;
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "Stone"){
            points--;
            Destroy(col.gameObject);
            //Implement Health damage here
            pm.TakeDamage(1);
            
        }
    }



}
