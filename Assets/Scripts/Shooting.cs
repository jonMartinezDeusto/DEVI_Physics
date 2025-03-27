using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform gun;
    public float force;
    MeshRenderer mr;

    // Update is called once per frame
    void Update()
    {
        Shoot();
        ShootRay();
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject go = Instantiate(bullet, gun.position, Quaternion.identity);
            go.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, force), ForceMode.Impulse);
        }
    }

    private void ShootRay()
    {
        RaycastHit hit;
        //MeshRenderer mr;
        if (Physics.Raycast(gun.position, new Vector3(0, 0, 1), out hit))
        {
            mr = hit.collider.gameObject.GetComponent<MeshRenderer>();
            if (mr != null)
            {
                mr.material.color = Color.green;
            }
        } else
        {
            if (mr != null)
            {
                mr.material.color = Color.red;
            }
        }
        //Debug.DrawLine(transform.position, new Vector3(0,0,1) * Mathf.Infinity, Color.yellow);
        
    }
}
