using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public PlayerControler i;
    public GameObject Audio;
    public GameObject Escenario;

    public bool InTime;

    public int casilla;

    void Start()
    {
        i = this;
    }

    void Update()
    {
        InTime = AudioSpeedChange.i.Intime;

        transform.position = Vector3.Lerp(transform.position, new Vector3(0.35f * casilla, transform.position.y, transform.position.z), 0.2f);
    }

    
    

    //King    
    public void KingUp()
    {
        if (InTime)
        {
            print("KingUp");
            ScenaryControler.i.Rotar(1);
        }
        else KingFail();
    }

    public void KingUpLeft()
    {
        if (InTime)
        {
            print("UpLeft");
            ScenaryControler.i.Rotar(1);
            casilla -= 1;
        }

        else KingFail();
    }

    public void KingUpRight()
    {
        if (InTime)
        {
            print("KingUpRight");
            ScenaryControler.i.Rotar(1);
            casilla += 1;
        }
        else KingFail();
    }

    public void KingLeft()
    {
        if (InTime)
        {
            print("KingLeft");
            casilla -= 1;
        }
        else KingFail();
    }

    public void KingRight()
    {
        if (InTime)
        {
            print("KingRight");
            casilla += 1;
        }
        else KingFail();
    }

    public void KingFail()
    {        
        print("KingFail");
        ScenaryControler.i.Rotar(1);
    }

    //Silver
    public void SilverUp()
    {

    }

    public void SilverUpLeft()
    {

    }

    public void SilverUpRight()
    {

    }

    public void SilverFail()
    {

    }

    //Knight
    public void KnightgLeft()
    {

    }

    public void KnightRight()
    {

    }

    public void KnightFail()
    {

    }
}
