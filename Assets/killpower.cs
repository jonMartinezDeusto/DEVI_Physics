using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killpower : MonoBehaviour
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
        if (collision.gameObject.layer == LayerMask.NameToLayer("killable"))
        {
            Destroy(collision.gameObject);
        }

    }
}
