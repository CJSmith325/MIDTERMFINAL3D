using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public void CompleteLevel ()
    {
        Debug.Log("Level Completed");
        EndGame();
    }
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }

    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
