using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    [SerializeField]
    private float force = 1000;

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bullet);
            bullet.transform.position = this.transform.localPosition;
            newBullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        }
    }

  
}
