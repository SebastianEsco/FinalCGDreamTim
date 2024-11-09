using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EffectManager : MonoBehaviour
{

    public PlayableDirector[] timelines;
    int efectoReproduciendo;

    public GameObject escena, suelo;
    public Light luz;

    public GameObject[] posicionesCamara;
    public Camera camara;

    private void Start()
    {
        foreach (var d in timelines)
        {
            d.Stop();
        }
    }

    public void ReproducirEfecto(int indexEfecto)
    {
        for (int i = 0; i < timelines.Length; i++)
        {
            if(i!= indexEfecto)
            {
                timelines[i].Stop();
            }
            else
            {
                timelines[i].Play();
                efectoReproduciendo = indexEfecto;
            }
        }
    }

    public void PausarEfecto()
    {
        if(Time.timeScale != 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        
    }

    public void ActivarEscena()
    {
        if(suelo.activeSelf)
        {
            escena.SetActive(true);
            suelo.SetActive(false);
        }
        else
        {
            escena.SetActive(false);
            suelo.SetActive(true);
        }
    }

    public void DiaNoche()
    {
        if(luz.intensity > 1)
        {
            luz.intensity = 0.3f;
        }
        else
        {
            luz.intensity = 1.5f;
        }
    }

    public void PosicionDeCamara(int posicion)
    {
        camara.transform.position = posicionesCamara[posicion].transform.position;
        camara.transform.rotation = posicionesCamara[posicion].transform.rotation;
    }

  


}
