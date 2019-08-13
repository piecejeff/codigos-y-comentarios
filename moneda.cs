using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneda : MonoBehaviour
{
    [SerializeField]
    public AudioSource MikuEFAudio;
    public AudioClip MonedaMikuA;

    public int pointsToAdd;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<P_Controller>() == null)
            return;
        MikuEFAudio.PlayOneShot(MonedaMikuA);
        puntaje.AddPoints(pointsToAdd);
        Destroy(gameObject);
        Debug.Log(pointsToAdd);


    }
}
