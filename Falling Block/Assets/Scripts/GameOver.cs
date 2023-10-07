using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI scoreNumberUI;
    bool isGameOver = true;

    private void Start()
    {
        FindObjectOfType<PlayerController>().OnPlayerDeath += this.OnGameOver;
    }

    private void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    public void OnGameOver()
    {
        gameOverScreen.SetActive(true);
        scoreNumberUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
    }
}
