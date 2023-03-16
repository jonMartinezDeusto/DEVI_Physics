using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]
    private float force = 1000;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bullet);
        var rigidbody = bullet.GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.forward * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  


    
    



}
