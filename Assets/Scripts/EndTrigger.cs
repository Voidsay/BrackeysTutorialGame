using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        Debug.Log("enter Trigger");
        gameManager.comleteLevel();
    }

}
