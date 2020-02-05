using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControler : MonoBehaviour
{
    public static PlayerControler i;
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
            GameplayManager.i.PointsUp(1);
        }
        else KingFail();
    }

    public void KingUpLeft()
    {
        if (InTime)
        {
            print("UpLeft");
            ScenaryControler.i.Rotar(1);            
            
            if (casilla > -3)
            {
                casilla -= 1;
                GameplayManager.i.PointsUp(1);
            }
            else KingFail();
        }

        else KingFail();
    }

    public void KingUpRight()
    {
        if (InTime)
        {
            print("KingUpRight");
            ScenaryControler.i.Rotar(1);
            if (casilla < 3)
            {
                casilla += 1;
                GameplayManager.i.PointsUp(1);
            }
            else KingFail();
        }
        else KingFail();
    }

    public void KingLeft()
    {
        if (InTime)
        {
            print("KingLeft");
            if (casilla > -3)
            {
                casilla -= 1;                
            }
            else KingFail();
        }
        else KingFail();
    }

    public void KingRight()
    {
        if (InTime)
        {
            print("KingRight");
            if (casilla < 3)
            {
                casilla += 1;
                
            }
            else KingFail();
        }
        else KingFail();
    }

    public void KingFail()
    {        
        print("KingFail");
        ScenaryControler.i.Rotar(1);
        GameplayManager.i.TempoFail();
    }

    //Silver
    public void SilverUp()
    {
        if (InTime)
        {
            ScenaryControler.i.Rotar(1);
            GameplayManager.i.PointsUp(1);
        }
        else SilverFail();
    }

    public void SilverUpLeft()
    {
        if (InTime)
        {
            ScenaryControler.i.Rotar(1);
            if (casilla > -3)
            {
                casilla -= 1;
                GameplayManager.i.PointsUp(1);
            }
            else SilverFail();
        }
        else SilverFail();
    }

    public void SilverUpRight()
    {
        if (InTime)
        {
            ScenaryControler.i.Rotar(1);
            if (casilla < 3)
            {
                casilla += 1;
                GameplayManager.i.PointsUp(1);
            }
            else SilverFail();
        }
        else SilverFail();
    }

    public void SilverFail()
    {
        ScenaryControler.i.Rotar(1);
        GameplayManager.i.TempoFail();
    }

    //Knight
    public void KnightgLeft()
    {
        if (InTime)
        {
            ScenaryControler.i.Rotar(2);
            if (casilla > -3)
            {
                casilla -= 1;
                GameplayManager.i.PointsUp(2);
            }
            else KnightFail();
        }
        else KnightFail();
    }

    public void KnightRight()
    {
        if (InTime)
        {
            ScenaryControler.i.Rotar(2);
            if (casilla < 3)
            {
                casilla += 1;
                GameplayManager.i.PointsUp(2);
            }
            else KnightFail();
        }
        else KnightFail();
    }

    public void KnightFail()
    {
        int r = Random.Range(-1,1);
        if (r == 0) r = 1;
        casilla += r;
        ScenaryControler.i.Rotar(2);
        GameplayManager.i.TempoFail();
    }
}
