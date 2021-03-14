using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded=false;

    public float restartDelay=1f;

    public GameObject completeLevelUI;

    public void comleteLevel()
    {
        Debug.Log("comlete Level procedure");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded=true;
            Debug.Log("game over");
            Invoke("Restar", restartDelay);
        }
    }

    void Restar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
