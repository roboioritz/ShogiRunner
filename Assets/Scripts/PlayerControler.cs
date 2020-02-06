using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControler : MonoBehaviour
{
    public static PlayerControler i;
    public GameObject Audio;
    public GameObject Escenario;
    public Vector2Int TablePos;

    public bool InTime;
    public bool DoMove;
    public bool Dead;

    public int casilla;

    void Start()
    {
        i = this;
        DoMove = true;
        TablePos = new Vector2Int(0, 0); //( Horizontal , Vertical/Rotacion )
    }

    void Update()
    {
        InTime = AudioSpeedChange.i.Intime;
        transform.position = Vector3.Lerp(transform.position, new Vector3(0.35f * casilla, transform.position.y, transform.position.z), 0.2f);
        TablePos.x = casilla;
        if (TablePos.y >= 60) TablePos.y -= 60;
    }        

    //King    
    public void KingUp()
    {
        if (InTime&&DoMove&&!Dead)
        {
            //print("KingUp");
            ScenaryControler.i.Rotar(1);
            GameplayManager.i.PointsUp(1);
            DoMove = false;
        }
        else KingFail();
    }

    public void KingUpLeft()
    {
        if (InTime && DoMove&&!Dead)
        {
            //print("UpLeft");
            
            DoMove = false;
            if (casilla > -3)
            {
                ScenaryControler.i.Rotar(1);
                casilla -= 1;
                GameplayManager.i.PointsUp(1);
            }
            else KingFail();
        }

        else KingFail();
    }

    public void KingUpRight()
    {
        if (InTime && DoMove&&!Dead)
        {
            //print("KingUpRight");
            
            DoMove = false;
            if (casilla < 3)
            {
                ScenaryControler.i.Rotar(1);
                casilla += 1;
                GameplayManager.i.PointsUp(1);
            }
            else KingFail();
        }
        else KingFail();
    }

    public void KingLeft()
    {
        if (InTime && DoMove&&!Dead)
        {
            //print("KingLeft");
            DoMove = false;
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
        if (InTime && DoMove&&!Dead)
        {
            //print("KingRight");
            DoMove = false;
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
        //print("KingFail");
        //ScenaryControler.i.Rotar(1);
        GameplayManager.i.TempoFail();
    }

    //Silver
    public void SilverUp()
    {
        if (InTime && DoMove&&!Dead)
        {
            ScenaryControler.i.Rotar(1);
            GameplayManager.i.PointsUp(1);
            DoMove = false;
        }
        else SilverFail();
    }

    public void SilverUpLeft()
    {
        if (InTime && DoMove&&!Dead)
        {
            
            DoMove = false;
            if (casilla > -3)
            {
                ScenaryControler.i.Rotar(1);
                casilla -= 1;
                GameplayManager.i.PointsUp(1);
            }
            else SilverFail();
        }
        else SilverFail();
    }

    public void SilverUpRight()
    {
        if (InTime && DoMove&&!Dead)
        {
            
            DoMove = false;
            if (casilla < 3)
            {
                ScenaryControler.i.Rotar(1);
                casilla += 1;
                GameplayManager.i.PointsUp(1);
            }
            else SilverFail();
        }
        else SilverFail();
    }

    public void SilverFail()
    {
        //ScenaryControler.i.Rotar(1);
        GameplayManager.i.TempoFail();
    }

    //Knight
    public void KnightgLeft()
    {
        if (InTime && DoMove&&!Dead)
        {
            
            DoMove = false;
            if (casilla > -3)
            {
                ScenaryControler.i.Rotar(2);
                casilla -= 1;
                GameplayManager.i.PointsUp(2);
            }
            else KnightFail();
        }
        else KnightFail();
    }

    public void KnightRight()
    {
        if (InTime && DoMove&&!Dead)
        {
            
            DoMove = false;
            if (casilla < 3)
            {
                ScenaryControler.i.Rotar(2);
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
        //if (r == 0) r = 1;
        //casilla += r;
        //ScenaryControler.i.Rotar(2);
        GameplayManager.i.TempoFail();
    }
}
