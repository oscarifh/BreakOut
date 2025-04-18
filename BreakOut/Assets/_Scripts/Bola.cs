using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public float VelBola = 15.0f;
    private bool isGameStarted = false;
    void Start()
    {
        Vector3 posicionInicialJugador = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicialJugador.y += 3;
        this.transform.position = posicionInicialJugador;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)||Input.GetButton("Submit"))
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = VelBola * Vector3.up;
            }


        }
    }
}