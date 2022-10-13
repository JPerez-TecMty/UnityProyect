using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int coinsOwned, totalCoins, playerLives;
    public GameObject playerSpawner;
    public GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        coinsOwned = 0;
        totalCoins = 3;
        playerLives = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CaptureCoin()
    {
        Debug.Log("Bye Coin");
        coinsOwned++;
        
    }

    public void PlayerDeath()
    {
        playerObject.transform.position = playerSpawner.transform.position;
        playerLives--;
    }
}
