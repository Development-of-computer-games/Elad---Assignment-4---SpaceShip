using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnLaserBossTrigger : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] TMPro.TextMeshPro msg;

    private void OnTriggerEnter2D(Collider2D other)
    { // getting the Player HealthSystem script to give damage and to check weather we die or not.
        var healthSystem = GetComponent<HealthSystem>();
        if (other.tag == triggeringTag && enabled)
        {
            healthSystem.Damage();
            //Destroy(this.gameObject);
            Destroy(other.gameObject);
            if (healthSystem.dead)
            {
                msg.SetText("Game Over!");
            }
       
          
            
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
