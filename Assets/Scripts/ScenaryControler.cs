using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenaryControler : MonoBehaviour
{
    static public ScenaryControler i;
    public float angulo;
    public float alpha;
    public float a,b;

    public bool spawneable;

    void Start()
    {
        i = this;
        alpha = 0;
        
    }
    
    void Update()
    {
        a = Mathf.Cos(alpha / 2 * Mathf.Deg2Rad);
        b = Mathf.Sin(alpha / 2 * Mathf.Deg2Rad);
        //transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(-b , 0, 0, a), 0.2f);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-alpha,0,0), 0.2f);
        spawneable = false;
        if ( alpha >= 0 &&  alpha <= 90)
        {
            if (transform.rotation.eulerAngles.x <= 360.05f - alpha && transform.rotation.eulerAngles.x >= 359.95f - alpha) spawneable = true;
        }
        else if (alpha > 90 &&  alpha <= 180)
        {
            if (540-transform.rotation.eulerAngles.x <= 360.05f - alpha && 540-transform.rotation.eulerAngles.x >= 359.95f - alpha) spawneable = true;
        }
        else if (alpha > 180 && alpha <= 270)
        {
            if (180-transform.rotation.eulerAngles.x <= 360.05f - alpha && 180-transform.rotation.eulerAngles.x >= 359.95f - alpha) spawneable = true;
        }
        else if (alpha > 270 && alpha <= 360)
        {
            if (transform.rotation.eulerAngles.x <= 360.05f - alpha && transform.rotation.eulerAngles.x >= 359.95f - alpha) spawneable = true;
        }
        else spawneable = false;
        ///print(( transform.rotation.eulerAngles.x) +"+"+(360 - alpha) +"="+(transform.rotation.eulerAngles.x - (360 - alpha)));
        //print("angulo:" + transform.rotation.eulerAngles.x);
        //print("alpha:" + alpha);
        //print(spawneable);
        //transform.rotation = Quaternion.Euler(-alpha, 0, 0);
    }

    public void Rotar(int grados)
    {
        alpha += 6 * grados;
        if (alpha >= 360) alpha -= 360;
        PlayerControler.i.TablePos += new Vector2Int(0, grados);
    }
}
