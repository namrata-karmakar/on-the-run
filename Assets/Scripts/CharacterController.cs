using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player1Position1;
    public GameObject player1Position2;
    public GameObject player2Position1;
    public GameObject player2Position2;

    public bool rightSide1;
    public bool rightSide2;    

    // Update is called once per frame
    void Update()
    {
        Player1Movement();
        Player2Movement();
    }

    public void Player1Movement(){
        if(Input.GetKeyDown(KeyCode.A) && rightSide1 == true){
            player1.transform.position = player1Position2.transform.position;
            rightSide1 = false;
        }
        else if (Input.GetKeyDown(KeyCode.A) && !rightSide1){
            player1.transform.position = player1Position1.transform.position;
            rightSide1 = true;
        }
    }
    public void Player2Movement(){
        if(Input.GetKeyDown(KeyCode.D) && rightSide2 == true){
            player2.transform.position = player2Position2.transform.position;
            rightSide2 = false;
        }
        else if(Input.GetKeyDown(KeyCode.D) && !rightSide2){
            player2.transform.position = player2Position1.transform.position;
            rightSide2 = true;
        }
    }

}
