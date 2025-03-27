using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fencer : MonoBehaviour
{
    public GameObject vallaPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (float i = 0; i < 20;  i+=0.7f)
        {
            GameObject go = Instantiate(vallaPrefab);
            go.transform.position = new Vector3(0, 0.56f, i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
