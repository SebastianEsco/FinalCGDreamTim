using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EffectManager : MonoBehaviour
{

    public PlayableDirector[] timelines;

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
            }
        }
    }


}
