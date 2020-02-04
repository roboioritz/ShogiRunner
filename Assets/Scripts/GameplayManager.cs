using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    static public GameplayManager i;

    public int points;
    public int multipler;
    public int chain;

    void Start()
    {
        i = this;
        multipler = 1;
    }
    
    void Update()
    {
        if (chain >= 5)
        {
            if(multipler<5)multipler++;
            chain = 0;
        }
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
