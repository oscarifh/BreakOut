using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour


{
    [SerializeField] public int limiteX = 30;
    [SerializeField] public float VelPaddle = 0.9f;


    new Transform transform;
    Vector3 mousePos2;
    Vector3 mousePos3;

    // Start is called before the first frame update
    void Start()
    {
        transform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        mousePos2 = Input.mousePosition;
        mousePos3.z = -Camera.main.transform.position.z;    
        mousePos3 = Camera.main.ScreenToWorldPoint(mousePos2);
        Vector3 pos = this.transform.position;
        
        

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.down * VelPaddle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.up * VelPaddle * Time.deltaTime);
        }*/

        transform.Translate(Input.GetAxis("Horizontal") *Vector3.down * VelPaddle * Time.deltaTime);

        Vector3 pos = transform.position;
        //pos.x = mousePos3.x;   
        //this.transform.position = pos;  

        if (pos.x < -limiteX)
        {
            pos.x = -limiteX;
        }
        else if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }
        transform.position = pos;
    }
}
