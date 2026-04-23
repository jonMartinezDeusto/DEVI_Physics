using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform gun;
    public float force;
    MeshRenderer mr;
    Color originalColor;

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
        if (Physics.Raycast(gun.position, new Vector3(0, 0, 1), out hit))
        {
            MeshRenderer newMr = hit.collider.gameObject.GetComponent<MeshRenderer>();
            if (newMr != null)
            {
                if (newMr != mr)
                {
                    // apuntamos a un blanco diferente: restaurar el anterior
                    if (mr != null) mr.material.color = originalColor;
                    mr = newMr;
                    originalColor = mr.material.color;
                }
                mr.material.color = Color.green;
            }
        }
        else
        {
            // no apuntamos a nada: restaurar color original
            if (mr != null)
            {
                mr.material.color = originalColor;
                mr = null;
            }
        }
    }
}
