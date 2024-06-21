using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public void playSounds()
    {
        GetComponent<AudioSource>().Play();
    }

    public void stopSounds()
    {
        GetComponent<AudioSource>().Stop();
    }
}
