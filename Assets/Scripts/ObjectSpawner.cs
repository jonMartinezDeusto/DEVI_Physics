using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnTarget;

    void Start()
    {
        Instantiate(spawnTarget);
         DrawAnSquadron();

    }

    private void DrawAnSquadron()
    {
        for (int i = 0; i < 50; i++)
        {
            Instantiate(spawnTarget, new Vector3(0, 0, 0 + i * 10), Quaternion.identity);
            Instantiate(spawnTarget, new Vector3(10, 0, 0 + i * 10), Quaternion.identity);
            Instantiate(spawnTarget, new Vector3(-10, 0, 0 + i * 10), Quaternion.identity);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
