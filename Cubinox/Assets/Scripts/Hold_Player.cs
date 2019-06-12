using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold_Player : MonoBehaviour
{

    private void OnCollisionStay2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

        if(rb != null)
        {
            rb.bodyType = RigidbodyType2D.Static;
            rb.transform.parent = transform;
        }
    }

}
