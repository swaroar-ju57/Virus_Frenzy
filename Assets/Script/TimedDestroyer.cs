﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroyer : MonoBehaviour
{
    [SerializeField]
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, timer);
    }
}
