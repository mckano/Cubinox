using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint_Control : MonoBehaviour
{

    GameObject checkpoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Checkpoint cp = collision.gameObject.GetComponent<Checkpoint>();

        if(cp != null)
        {
            checkpoint = cp.gameObject;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ResetPlayer rp = collision.gameObject.GetComponent<ResetPlayer>();

        if (rp != null)
        {
            ResetPositon();
        }
    }

    void ResetPositon()
    {
        transform.position = checkpoint.transform.position;
    }
}
