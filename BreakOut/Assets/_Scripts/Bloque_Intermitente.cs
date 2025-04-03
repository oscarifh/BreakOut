using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Intermitente : Bloque
{
    private Renderer renderer;
    private bool isOn = true;
    private float timer = 0f;
    private float cycleTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= cycleTime)
        {
            isOn = !isOn;
            renderer.enabled = isOn;
            timer = 0f;
        }
    }
}
