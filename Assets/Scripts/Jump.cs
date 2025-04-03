using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    
    public int jumpForce=200;

    [SerializeField]
    private int speed = 10;
    [SerializeField]
    private bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        JumIsNeeded();
    }

    private void JumIsNeeded()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Espacio pulsado");
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            canJump = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            canJump = true;
        }
  
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Time.deltaTime * Vector3.forward * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Time.deltaTime * Vector3.back * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Time.deltaTime * Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Time.deltaTime * Vector3.right * speed;
        }
    }
}





