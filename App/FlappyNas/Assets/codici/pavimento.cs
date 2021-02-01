using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class pavimento : MonoBehaviour
{
    Vector2 posInizialePavimento; // posizione iniziale in cui parte il pavimento

    void Start()
    {
        posInizialePavimento = transform.position; //assegno a posIniziale la prima posizione in cui spawna il pavimento
    }

    void Update()
    {
        if (!Controller.gameover)
        {
            if (transform.position.x >= -0.76f)
                transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, transform.position.y);
            else
                transform.position = posInizialePavimento;
        }
    }
}
