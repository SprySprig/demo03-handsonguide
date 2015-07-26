using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour
{
    public int coinValue = 1;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerStats stats = collider.gameObject.GetComponent<PlayerStats>();
        stats.CollectCoin(this.coinValue);
        Destroy(this.gameObject);
    }
}
