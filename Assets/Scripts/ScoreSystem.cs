using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreSystem : MonoBehaviour
{
    public int points;
    
    public TextMeshProUGUI scorePoints;

    void Start()
    {
        points = 0;
        scorePoints = GetComponent<TextMeshProUGUI>();
    } 

    private void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Fruit"){
            points++;
            Debug.Log("yummy");
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "Stone"){
            points--;
            Debug.Log("ahhh stone");
            Destroy(col.gameObject);
            //Implement Health damage here 
        }
    }
    void Update(){
        //scorePoints.SetText(points.ToString());
    }  



}
