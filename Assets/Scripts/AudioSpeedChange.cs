using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpeedChange : MonoBehaviour
{
    static public AudioSpeedChange i;

    private AudioSource pista;

    public float points;
    public float acceleration;
    public float pitch;
    public float PPM;
    public float PPMbase;    
    public float margen;

    public bool Intime;

    private float tempo;
    private float pretempo;
    private float postempo;
    private int counter;


    void Start()
    {
        i = this;
        pista = GetComponent<AudioSource>();
        pista.Play(0);
        points = 1;
        acceleration = 2f / 3000f;
        tempo = 0;
        PPM = PPMbase;
        pretempo = tempo + (margen / PPM);
        postempo = tempo - (margen / PPM);
    }

    void Update()
    {
        points = GameplayManager.i.points;
        tempo += Time.deltaTime;
        pretempo += Time.deltaTime;
        postempo += Time.deltaTime;

        pitch = 1 + (points * acceleration);
        PPM = pitch * PPMbase;
        pista.pitch = pitch;

        if (pretempo > 60 / PPM && pretempo < (60 / PPM) + Time.deltaTime)
        {
            Intime = true;
            //print("Inicio");
        }

        if (tempo > 60 / PPM)
        {
            tempo = 0;
            counter++;
            if (counter == GameplayManager.i.nivel)
            {
                counter = 0;
                GameplayManager.i.DoSpawn = true;
                //print("a"+ScenaryControler.i.transform.rotation.eulerAngles.x);
                //print("b"+(360 - ScenaryControler.i.alpha));
            }
            pretempo = tempo + (margen / PPM);
            //print("pa");
            
        }        

        if (postempo > 60 / PPM)
        {
            Intime = false;
            //print("Final");
            postempo = tempo - (margen / PPM);
            GameplayManager.i.TempoFail();
            if (PlayerControler.i.DoMove == true)
            {

            }
            PlayerControler.i.DoMove = true;

        }
    }
}