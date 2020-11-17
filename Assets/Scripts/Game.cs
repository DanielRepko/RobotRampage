using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // the static instance variable for the singleton
    private static Game instance;

    [SerializeField]
    RobotSpawn[] spawns;

    public int enemiesLeft;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        SpawnRobots();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //spawns the robots
    private void SpawnRobots()
    {
        foreach(RobotSpawn spawn in spawns)
        {
            spawn.SpawnRobot();
            enemiesLeft++;
        }
    }
}
