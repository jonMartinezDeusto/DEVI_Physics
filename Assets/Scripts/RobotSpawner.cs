using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject robot;

    void Start()
    {
        Instantiate(robot);


        for (int i = 0; i < 50; i++)
        {
            Instantiate(robot, new Vector3(0    , 0         , 0+ i * 10) , Quaternion.identity);
            Instantiate(robot, new Vector3(10   , 0         , 0 + i * 10), Quaternion.identity);
            Instantiate(robot, new Vector3(-10  , 0         , 0 + i * 10), Quaternion.identity);


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
