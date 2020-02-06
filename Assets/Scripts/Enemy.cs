using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector2Int TablePos;
    public string type;
    public int points;

    void Start()
    {
        Destroy(gameObject, 30f);             
        transform.rotation = Quaternion.Euler(90,0,90);
        if (TablePos.y >= 60) TablePos.y -= 60;

        {//if(PlayerControler.i.TablePos.y >= 0 && PlayerControler.i.TablePos.y <= 15)
         //transform.rotation = Quaternion.Euler(180 -((-6*PlayerControler.i.TablePos.y)-ScenaryControler.i.transform.rotation.eulerAngles.x),0,90);
         //if (PlayerControler.i.TablePos.y > 15 && PlayerControler.i.TablePos.y <= 30)

            //transform.rotation = Quaternion.Euler(((180 - ((-6 * (30 - PlayerControler.i.TablePos.y)) - (ScenaryControler.i.transform.rotation.eulerAngles.x)))), 0, 90);            

            //transform.rotation = Quaternion.Euler(-180 + ((12 * PlayerControler.i.TablePos.y) + 2*ScenaryControler.i.transform.rotation.eulerAngles.x), 0, 90);
            //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, 90);
        }
    }
    
    void Update()
    {
        
    }

    public bool EnemyRadar()
    {
        switch (type)
        {
            case "Pawn":
                if (PlayerControler.i.TablePos.x == TablePos.x && PlayerControler.i.TablePos.y == TablePos.y - 1) return true;                     
                break;
            case "Lancer":
                for (int i = 0; i < 6; i++)
                {
                    if (PlayerControler.i.TablePos.x == TablePos.x && PlayerControler.i.TablePos.y == TablePos.y - i - 1) return true;
                }
                break;
            case "Knight":
                if (PlayerControler.i.TablePos.x == TablePos.x + 1 && PlayerControler.i.TablePos.y == TablePos.y - 2) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x - 1 && PlayerControler.i.TablePos.y == TablePos.y - 2) return true;
                break;
            case "Silver":
                if (PlayerControler.i.TablePos.x == TablePos.x     && PlayerControler.i.TablePos.y == TablePos.y - 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x + 1 && PlayerControler.i.TablePos.y == TablePos.y - 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x - 1 && PlayerControler.i.TablePos.y == TablePos.y - 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x + 1 && PlayerControler.i.TablePos.y == TablePos.y + 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x - 1 && PlayerControler.i.TablePos.y == TablePos.y + 1) return true;
                break;
            case "Gold":
                if (PlayerControler.i.TablePos.x == TablePos.x     && PlayerControler.i.TablePos.y == TablePos.y - 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x + 1 && PlayerControler.i.TablePos.y == TablePos.y - 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x - 1 && PlayerControler.i.TablePos.y == TablePos.y - 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x + 1 && PlayerControler.i.TablePos.y == TablePos.y)     return true;
                if (PlayerControler.i.TablePos.x == TablePos.x - 1 && PlayerControler.i.TablePos.y == TablePos.y)     return true;
                if (PlayerControler.i.TablePos.x == TablePos.x     && PlayerControler.i.TablePos.y == TablePos.y + 1) return true;
                break;
            case "Bishop":
                for (int i = 0; i < 6; i++)
                {
                    if (PlayerControler.i.TablePos.x == TablePos.x + i + 1 && PlayerControler.i.TablePos.y == TablePos.y - i - 1) return true;
                    if (PlayerControler.i.TablePos.x == TablePos.x - i - 1 && PlayerControler.i.TablePos.y == TablePos.y - i - 1) return true;
                }
                break;
            case "Tower":
                for (int i = 0; i < 6; i++)
                {
                    if (PlayerControler.i.TablePos.x == TablePos.x + i + 1 && PlayerControler.i.TablePos.y == TablePos.y) return true;
                    if (PlayerControler.i.TablePos.x == TablePos.x - i - 1 && PlayerControler.i.TablePos.y == TablePos.y) return true;
                    if (PlayerControler.i.TablePos.x == TablePos.x && PlayerControler.i.TablePos.y == TablePos.y - i - 1) return true;
                }
                break;
            case "King":
                if (PlayerControler.i.TablePos.x == TablePos.x     && PlayerControler.i.TablePos.y == TablePos.y - 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x + 1 && PlayerControler.i.TablePos.y == TablePos.y - 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x - 1 && PlayerControler.i.TablePos.y == TablePos.y - 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x + 1 && PlayerControler.i.TablePos.y == TablePos.y)     return true;
                if (PlayerControler.i.TablePos.x == TablePos.x - 1 && PlayerControler.i.TablePos.y == TablePos.y)     return true;
                if (PlayerControler.i.TablePos.x == TablePos.x     && PlayerControler.i.TablePos.y == TablePos.y + 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x + 1 && PlayerControler.i.TablePos.y == TablePos.y + 1) return true;
                if (PlayerControler.i.TablePos.x == TablePos.x - 1 && PlayerControler.i.TablePos.y == TablePos.y + 1) return true;
                break;


        }
        return false;
    }

    public void Destroy()
    {
        GameplayManager.i.Enemies.Remove(this);
        Destroy(gameObject);
    }

}
