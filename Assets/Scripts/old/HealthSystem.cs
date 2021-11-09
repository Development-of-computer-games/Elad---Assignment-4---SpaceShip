using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Represents an object that has a given amount of lives, and is destroyed when the number of lives becomes 0.
 */
public class HealthSystem : MonoBehaviour
{
    [SerializeField] int lives = 3;
    public GameObject[] hearts;
    public bool dead;

    public void Damage() {


        --lives;
        Destroy(hearts[lives].gameObject);
       
        gameObject.transform.localScale *= 0.75f; // Notify the player that a damage was done
        if (lives<1) {
            dead = true;
            Destroy(this.gameObject);
        }
    }
}
