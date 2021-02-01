using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class punteggio : MonoBehaviour
{
    public static int punti;
    // Start is called before the first frame update
    void Start()
    {
        punti = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = punti.ToString();
    }
}
