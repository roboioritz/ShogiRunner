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
        //transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(transform.rotation.x + 0.05f, transform.rotation.y  , transform.rotation.z, transform.rotation.w), Time.time * 10 / AudioSpeedChange.i.PPM);
        //transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(a*a+b*b,a*b-b*a,0,0), Time.time * 0.1f / AudioSpeedChange.i.PPM);
        //transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(a,b, 0, 0), Time.time * 0.1f / AudioSpeedChange.i.PPM);

        //transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(0,0, -2*b*a, b*b+a*a), Time.time * 1f / AudioSpeedChange.i.PPM);
        transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(-b , 0, 0, a), 0.2f);

        //transform.rotation = new Quaternion(-b, 0, 0, a);
        

        //transform.Rotate(new Vector3(angulo ,0,0),Space.World);
        //angulo =  transform.rotation.eulerAngles.x + 0.0003f;

        //transform.RotateAround(new Vector3(0,0,0),new Vector3(1,0,0),6f);

        /*print("x = "+transform.rotation.x);
        print("y = " + transform.rotation.y);
        print("z = " + transform.rotation.z);
        print("w = " + transform.rotation.w);*/
    }

    public void Rotar(int grados)
    {
        alpha += 6 * grados;
    }
}
