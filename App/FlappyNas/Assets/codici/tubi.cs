using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubi : MonoBehaviour
{
    bool count = false; //valore boolean che mi indica se il tubo sia stato contato nel punteggio
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!Controller.gameover)
            transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, transform.position.y);
        if(transform.position.x < -6) //se il tubo esce dallo schermo lo elimino
        {
            Destroy(gameObject); //eliminazione del tubo
        }

        if(!count && transform.position.x < -4) //se ll tubo non è stato contato e si trova dietro l'uccello aumento il puntegio
        {
            audioSource.Play();
            count = true;
            punteggio.punti += 1;

        }
    }
}
