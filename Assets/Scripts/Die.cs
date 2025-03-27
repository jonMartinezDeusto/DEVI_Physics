using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Die : MonoBehaviour
{
    public int maxHealth;
    public int health;

    public void Start()
    {
        health = maxHealth;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            health--;
            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
            Debug.Log("Golpe");
            
        }
        Debug.Log("RayCast?");
    }
}
