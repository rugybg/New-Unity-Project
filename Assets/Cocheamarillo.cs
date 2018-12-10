using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cocheamarillo : MonoBehaviour
{
    public Text continua;
    float velocidad = 0.1f;
    public KeyCode teclaAsignada;
    public string nombre;
    int cuenta = 0;
    public Text marcador1;
    public Text ganador1;
    public Coches Coches;
    

    // Update is called once per frame
    void Update()
    {
        if (cuenta == 100)
        {

            if (Input.GetKeyDown(teclaAsignada))
            {
                ganador1.text = "El ganador es: " + nombre;
                continua.gameObject.SetActive(false);
                ganador1.gameObject.SetActive(true);
                Coches.dale.gameObject.SetActive(false);
                Coches.ganador.gameObject.SetActive(false);

            }
        }

        else
        {ganador1.gameObject.SetActive(false);
            
            if (Input.GetKeyDown(teclaAsignada))

            {
                
                this.transform.Translate(new Vector3(velocidad, 0, 0));
                cuenta++;
                marcador1.text = "" + cuenta;
                Debug.Log(continua);
            }
        }
    }
}