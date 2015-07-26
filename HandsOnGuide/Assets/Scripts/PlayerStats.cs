using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
    public int health = 6;
    public int coinsCollected = 0;

    void Start()
    {

    }

    void Update()
    {

    }

    public void CollectCoin(int coinValue)
    {
        this.coinsCollected += coinValue;
    }
}
