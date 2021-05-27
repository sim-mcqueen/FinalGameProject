using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Honk : MonoBehaviour
{
    public AudioSource honkSource;

    public void PlayHonk()
    {
        var honkSource = GetComponent<AudioSource>();
        if (honkSource != null)
        {
            honkSource.Play();
        }
    }
}
