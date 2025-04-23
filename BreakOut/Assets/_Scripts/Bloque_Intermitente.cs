using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Intermitente : Bloque
{
    new private Renderer renderer;
    new private Collider collider;
    private bool isOn = true;
    private float timer = 0f;
    private float cycleTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>(); // Obtén el componente Collider
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= cycleTime)
        {
            isOn = !isOn;
            renderer.enabled = isOn;
            collider.enabled = isOn; // Activa o desactiva el Collider junto con el Renderer
            timer = 0f;
        }
    }
}
