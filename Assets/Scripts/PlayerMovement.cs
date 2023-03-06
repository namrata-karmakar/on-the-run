using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }
    }

    void TakeDamage(int damage) {
        currentHealth -= damage; 
        healthBar.SetHealth(currentHealth);
    }
}
