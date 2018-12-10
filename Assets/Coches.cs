using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coches : MonoBehaviour
{
    public Text dale;
    float velocidad = -0.1f;
    public KeyCode teclaAsignada;
    public string nombre;
    int suma = 0;
    public Text marcador1;
    public Text ganador;
    public Cocheamarillo Cocheamarillo;

    // Update is called once per frame
    void Update()
    {
        if (suma == 10)
        {

            if (Input.GetKeyDown(teclaAsignada))
            {
                ganador.text = "El ganador es: " + nombre;
                dale.gameObject.SetActive(false);
                ganador.gameObject.SetActive(true);
                Cocheamarillo.continua.gameObject.SetActive(false);
                Cocheamarillo.ganador1.gameObject.SetActive(false);
                Cocheamarillo.marcador1.gameObject.SetActive(false);
            }
        }

        else
        {
            ganador.gameObject.SetActive(false);

            if (Input.GetKeyDown(teclaAsignada))

            {
                this.transform.Translate(new Vector3(velocidad, 0, 0));
                suma++;
                marcador1.text = "" + suma;
                Debug.Log(dale);
            }
        }
    }
}