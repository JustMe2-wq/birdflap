using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text ScoreText;
    public GameObject gameOverScreen;

    [ContextMenu("AddScore")]
    public void addscore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        ScoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
