using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] spawneable;    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();

    }

    private void SpawnObjects()
    {
        for (int i = 0; i < spawneable.Length; i++)
        {
            Instantiate(spawneable[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
