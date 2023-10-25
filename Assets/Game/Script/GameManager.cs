using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;
    public GameObject gameOverPanel;

    public float speedMultiplier;

    void EndGame() 
    {
        Debug.Log("GAME OVER");
    }
    
    // Update is called once per frame
    void Update()
    {
        speedMultiplier += Time.deltaTime * 0.1f;

        timer += Time.deltaTime;

        if(timer > timeBetweenSpawns) 
        {
            timer = 0;
            int randNum = Random.Range(0, 3);
            Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
