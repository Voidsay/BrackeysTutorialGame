using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo) 
    {
        if(collisionInfo.gameObject.tag=="Obstecale")
        {
            movement.enabled=false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
