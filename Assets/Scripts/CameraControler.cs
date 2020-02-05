using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    private int casilla;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        casilla = PlayerControler.i.casilla;
        transform.position = Vector3.Lerp(transform.position, new Vector3(0.175f * casilla, transform.position.y, transform.position.z), 0.2f);
    }
}

