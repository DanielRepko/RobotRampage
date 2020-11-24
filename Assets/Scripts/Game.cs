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

    public GameUI gameUI;
    public GameObject player;
    public int score;
    public int waveCountdown;
    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        StartCoroutine("increaseScoreEachSecond");
        isGameOver = false;
        Time.timeScale = 1;
        waveCountdown = 30;
        enemiesLeft = 0;
        StartCoroutine("updateWaveTimer");

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

        gameUI.SetEnemyText(enemiesLeft);
    }

    // updates the wave timer
    private IEnumerator updateWaveTimer()
    {
        //while the game is still going
        while (!isGameOver)
        {
            yield return new WaitForSeconds(1f);
            // decrement waveCountdown
            waveCountdown--;
            //setting the wave text
            gameUI.SetWaveText(waveCountdown);
            
            // once the countdown reaches zero
            if(waveCountdown == 0)
            {
                // spawn the next wave of robots
                SpawnRobots();
                waveCountdown = 30;
                gameUI.ShowNewWaveText();
            }
        }
    }

    //removing enemies
    public static void RemoveEnemy()
    {
        instance.enemiesLeft--;
        instance.gameUI.SetEnemyText(instance.enemiesLeft);

        //give player a bonus when they clear a wave
        if(instance.enemiesLeft == 0)
        {
            instance.score += 50;
            instance.gameUI.ShowWaveClearBonus();
        }
    }

    public void AddRobotKillToScore()
    {
        score += 10;
        gameUI.SetScoreText(score);
    }

    IEnumerator increaseScoreEachSecond()
    {
        while (!isGameOver)
        {
            yield return new WaitForSeconds(1);
            score += 1;
            gameUI.SetScoreText(score);
        }
    }
}
