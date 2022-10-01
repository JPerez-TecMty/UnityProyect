using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int coinsOwned, totalCoins;
    // Start is called before the first frame update
    void Start()
    {
        coinsOwned = 0;
        totalCoins = 3;
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
}
