using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpeedChange : MonoBehaviour
{
    private AudioSource pista;
    public float points;
    public float acceleration;

    void Start()
    {
        pista = GetComponent<AudioSource>();
        pista.Play(0);
        points = 1;
    }
    
    void Update()
    {
        //Debug.Log("pich: " + pista.pitch);
        points += acceleration * Time.deltaTime;
        pista.pitch = points;
    }
}
