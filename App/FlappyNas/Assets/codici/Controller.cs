using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float timer; //misura il tempo che intercorre fra lo spawn di un set di tubi e altri
    float Srate = 3f; //frequenza con cui spawnare i tubi. In questo caso 3 secondi
    public GameObject tubo;
    public static bool gameover;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (!gameover)
        {
            timer += Time.deltaTime; //il timer crescerà ad ogni frame
            if (timer >= Srate)
            {
                timer -= Srate; //sottraggo al timer quei 3 secondi, in modo da resettare la spawn dei tubi
                Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 2f)); //scelgo dove far spawnare il tubo. Con la funzione random il gioco sceglie un numero casuale tra -1 e 2
                Instantiate(tubo, spawnPos, Quaternion.identity); //faccio spawnare i tubi
            }
        }
    }
}
