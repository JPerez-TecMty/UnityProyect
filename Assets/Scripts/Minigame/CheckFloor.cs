using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Checks if the character is touching the floor
public class CheckFloor : MonoBehaviour
{
    public GameObject mainCamera;

    public bool isTouchingFloor;

    private void Start()
    {
        isTouchingFloor = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.name);
        if(collision.collider.name == "TerrainCollider")
        {

            Debug.Log("Is touching floor");
            isTouchingFloor = true;
        }
        else if(collision.collider.tag == "Coin")
        {
            Debug.Log("Touched coin");
            collision.gameObject.SetActive(false);
            mainCamera.GetComponent<LevelController>().CaptureCoin();
        }
        else if(collision.collider.tag == "Obstacle")
        {
            mainCamera.GetComponent<LevelController>().PlayerDeath();
        }
        

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "TerrainCollider")
        {
            Debug.Log("Not touching floor");
            isTouchingFloor = false;
        }
    }
}
