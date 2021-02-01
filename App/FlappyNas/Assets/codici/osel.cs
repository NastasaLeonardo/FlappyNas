using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class osel : MonoBehaviour
{
    Rigidbody2D rb; //componente fisico di unity
    public GameObject gameOver;
    public GameObject restart;
    public AudioClip[] audioClips;
    AudioSource audioSource;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !Controller.gameover) //alla pressione del mouse la sprite dell'uccello salterà
        {
            audioSource.PlayOneShot(audioClips[0]);
            rb.velocity = new Vector2(0f, 7f); //salto
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        audioSource.PlayOneShot(audioClips[1]);
        Controller.gameover = true;
        gameOver.SetActive(true);
        restart.SetActive(true);
    } 
}
