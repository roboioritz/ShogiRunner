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
    public GameObject KingObject;
    public GameObject SilverObject;
    public GameObject KnightObject;

    public Text canvasPoints;
    public Text canvasMultipler;

    void Start()
    {
        i = this;
        multipler = 1;
        points = 0;
    }
    
    void Update()
    {
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
}
