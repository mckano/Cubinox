using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public float minX, maxX, minY, maxY;
    public Transform target;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<Player_Motor>().transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, minX, maxX), Mathf.Clamp(target.position.y, minY, maxY), 0) + offset;
    }
}
