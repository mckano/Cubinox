using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Same_Layer : MonoBehaviour
{

    public GameObject player;

    Player_Motor pm;

    // Start is called before the first frame update
    void Start()
    {
        pm = player.GetComponent<Player_Motor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.currentColor == Player_Motor.States.blackey)
            gameObject.layer = 10;
        else if (pm.currentColor == Player_Motor.States.whitey)
            gameObject.layer = 11;
    }
}
