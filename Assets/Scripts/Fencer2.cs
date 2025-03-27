using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fencer2 : MonoBehaviour
{
    public GameObject vallaPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (float j = -3.5f; j < 20; j += 5)
        {
            for (float i = -10; i < 20; i += 0.7f)
            {
                GameObject go = Instantiate(vallaPrefab);
                go.transform.position = new Vector3(i, 0, j);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
