using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenaryControler : MonoBehaviour
{
    static public ScenaryControler i;
    public float angulo;
    public float alpha;
    public float a,b;

    void Start()
    {
        i = this;
        alpha = 0;
        
    }
    
    void Update()
    {
        a = Mathf.Cos(alpha / 2 * Mathf.Deg2Rad);
        b = Mathf.Sin(alpha / 2 * Mathf.Deg2Rad);        
        transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(-b , 0, 0, a), 0.2f);        
    }

    public void Rotar(int grados)
    {
        alpha += 6 * grados;
    }
}
