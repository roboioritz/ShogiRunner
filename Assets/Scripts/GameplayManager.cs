using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    static public GameplayManager i;

    public int points;
    public int multipler;
    public int chain;

    public GameObject KingButtons;
    public GameObject SilverButtons;
    public GameObject KnightButtons;
    public GameObject KingKanji;
    public GameObject SilverKanji;
    public GameObject KnightKanji;
    public GameObject KingLetra;
    public GameObject SilverLetra;
    public GameObject KnightLetra;

    public GameObject enemy;
    public List<Enemy> Enemies;
    private GameObject e;

    public Text canvasPoints;
    public Text canvasMultipler;

    private float a, b,alpha;
    

    void Start()
    {
        i = this;
        multipler = 1;
        points = 0;
        
    }
    
    void Update()
    {
        alpha = PlayerControler.i.TablePos.y*6 + 120;
        a = Mathf.Cos(alpha / 2 * Mathf.Deg2Rad);
        b = Mathf.Sin(alpha / 2 * Mathf.Deg2Rad);

        if (chain >= 5)
        {
            if(multipler<5)multipler++;
            chain = 0;
        }
        canvasMultipler.text = "X " + multipler;
        canvasPoints.text = "" + points + " PTS";
    }

    public void PointsUp (int p)
    {
        points += p * multipler;
        chain++;
    }

    public void TempoFail()
    {
        chain = 0;
        multipler = 1;
    }

    public void SpawnEnemy()
    {
        //Instantiate(enemy, new Vector3(PlayerControler.i.TablePos.x * 0.35f, 0, 0), Quaternion.Euler((PlayerControler.i.TablePos.y * 3) + 180, 0,90), ScenaryControler.i.transform);
        e=Instantiate(enemy, new Vector3(0,0,0), Quaternion.Euler(0, 0, 90), ScenaryControler.i.transform);
        e.GetComponent<Enemy>().TablePos = new Vector2Int(PlayerControler.i.TablePos.x, PlayerControler.i.TablePos.y + 30);
        print("tablepos="+((PlayerControler.i.TablePos.y * -6) +360));
        print("scenary=" + ScenaryControler.i.transform.rotation.eulerAngles.x);
        print("resta = " + (((PlayerControler.i.TablePos.y * -6) + 360) - ScenaryControler.i.transform.rotation.eulerAngles.x));
        print("suma = " + (((PlayerControler.i.TablePos.y * -6) + 360) + ScenaryControler.i.transform.rotation.eulerAngles.x));
        print("resta resta = " + (-((PlayerControler.i.TablePos.y * -6) + 360) - ScenaryControler.i.transform.rotation.eulerAngles.x));
        print("resta suma = " + (-((PlayerControler.i.TablePos.y * -6) + 360) + ScenaryControler.i.transform.rotation.eulerAngles.x));
        //Enemies.Add(e.GetComponent<Enemy>());
    }

}
