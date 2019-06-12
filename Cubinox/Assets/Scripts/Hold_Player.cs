using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold_Player : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player_Motor pm = collision.gameObject.GetComponent<Player_Motor>();

        if(pm != null)
        {
            pm.transform.parent = transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Player_Motor pm = collision.gameObject.GetComponent<Player_Motor>();

        if (pm != null)
        {
            pm.transform.parent = null;
        }
    }
}
