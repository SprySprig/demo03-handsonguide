﻿using UnityEngine;
using System.Collections;

public class CheckpointTrigger : MonoBehaviour
{
    public bool isTriggered;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            isTriggered = true;
        }
    }
}
