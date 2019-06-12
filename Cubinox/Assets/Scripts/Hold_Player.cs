using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold_Player : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.transform.parent = transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.transform.parent = null;
        }
    }

}
