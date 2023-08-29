using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded=false;
    public float restartdelay = 1f;
    public GameObject completeLevelUI;
    public void CompleteGame()
    {
        Debug.Log("Hurray!!, Level Complete");
        completeLevelUI.SetActive(true);
    }
  public void EndGame()
    {
        if (gameEnded==false)
        {
            gameEnded = true;
            Debug.Log("GameOver");
            //Restarting the Game
            Invoke("Restart", restartdelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
