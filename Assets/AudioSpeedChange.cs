using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpeedChange : MonoBehaviour
{
    public AudioSpeedChange i;
    private AudioSource pista;
    public float points;
    public float acceleration;
    public float pitch;
    public float PPM;
    public float PPMbase;

    private float tempo;

    void Start()
    {
        i = this;
        pista = GetComponent<AudioSource>();
        pista.Play(0);
        points = 1;
        acceleration = 2f / 3000f;
    }

    void Update()
    {
        points += 1 * Time.deltaTime;
        tempo += Time.deltaTime;

        pitch = 1 + (points * acceleration);
        PPM = pitch * PPMbase;
        pista.pitch = pitch;

        if (tempo > 60 / PPM)
        {
            tempo = 0;
            print("pa");
        }
    }
}