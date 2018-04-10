using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public Text scoreText;
    public Text restartText;
    public Text gameOverText;

    private bool gameOver;
    private bool restart;
    private int score;

    void Start ()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
       StartCoroutine (SpawnWaves()); // Starta koden inom SpawnWaves.
    }

    void Update()
    {
        if (restart) //Om restart är sant.
        {
            if (Input.GetKeyDown (KeyCode.R)) // Om R trycks ner, kör om spelet.
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

    IEnumerator SpawnWaves ()
    {
        yield return new WaitForSeconds(startWait); // Vänta innan du börjar spawna fiender.
        while (true)
        {
            for (int i = 0; i < hazardCount; i++) // Spawna så många fiender som jag sätter.
            {
                GameObject hazard = hazards[Random.Range (0,hazards.Length)]; //Vilka fiender som ska spawnas.
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z); // Vart fienderna ska spawnas.
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation); // Instantiera en hazard.
                yield return new WaitForSeconds(spawnWait); // Vänta med att spawna en fiende.
            }
            yield return new WaitForSeconds(waveWait); //Vänta med att spawna fler fiender.

            if (gameOver)
            {
                restartText.text = "Press 'R' for restart";
                restart = true;
                break;
            }
        }
    }

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore () // Uppdatera poängen.
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver ()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
}
