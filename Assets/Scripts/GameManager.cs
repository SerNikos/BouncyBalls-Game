using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public GameObject WinText;
    public GameObject RestartButton;


    public void ScoreUp()
    {
        score++;
        if (score == 4)
        {
            Win();
        }
    }
    
    void Win()
    {
        WinText.SetActive(true);
        RestartButton.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
