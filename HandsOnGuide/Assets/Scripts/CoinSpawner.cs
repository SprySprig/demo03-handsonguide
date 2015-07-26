﻿using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinSpawnPoint;
    public Object[] coinPrefabs;


    void Start()
    {
        this.SpawnCoin();
    }

    void Update()
    {

    }

    void SpawnCoin()
    {
        int random = Random.Range(0, coinPrefabs.Length);
        GameObject coin = Object.Instantiate(coinPrefabs[random],
            coinSpawnPoint.transform.position,
            coinSpawnPoint.transform.rotation) as GameObject;

        coin.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-120, 120), 700));
    }
}
