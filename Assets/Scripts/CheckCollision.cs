using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="Capsule")
        {
            Debug.Log("Comienzo a chocar");
        }
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            Debug.Log("Estoy chocando");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            Debug.Log("He dejado de chocar");
            Destroy(this.gameObject);

        }

    }
}


