using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public GameObject referencia;
    public Material shader;
    bool reproduciendo;
    float smoothVisible;
    public float velocidad = 0.1f;

    void Start()
    {
        referencia.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (referencia.activeSelf)
        {
            if(smoothVisible < 1)
            {
                smoothVisible += velocidad * Time.deltaTime;
            }
            
            

        }
        else
        {
            if (smoothVisible > 0)
            {
                smoothVisible -= velocidad * Time.deltaTime * 4.5f;
            }
            
        }

        shader.SetFloat("_Visible", smoothVisible);
    }


}



