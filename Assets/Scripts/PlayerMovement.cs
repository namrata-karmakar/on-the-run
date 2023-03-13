using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int maxHealth = 4;
    public int currentHealth;
    private CharacterController myCharacterController;
        

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space)) {
            TakeDamage(1);
            Debug.Log(currentHealth);
        }
        
    }
    public void TakeDamage(int damage) {
        currentHealth -= damage; 
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(4);
    }

}

