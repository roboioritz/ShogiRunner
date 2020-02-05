using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector2Int TablePos;

    void Start()
    {
        Destroy(gameObject, 60f);
        transform.position = new Vector3(0.35f * TablePos.x, 0, 0);
        if(PlayerControler.i.TablePos.y >= 0 && PlayerControler.i.TablePos.y <= 15)
        transform.rotation = Quaternion.Euler(180 -((-6*PlayerControler.i.TablePos.y)-ScenaryControler.i.transform.rotation.eulerAngles.x),0,90);
        if (PlayerControler.i.TablePos.y > 15 && PlayerControler.i.TablePos.y <= 30)
            transform.rotation = Quaternion.Euler(180 + ((-6 * PlayerControler.i.TablePos.y) - ScenaryControler.i.transform.rotation.eulerAngles.x), 0, 90);
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, 90);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
