using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Color_Changer : MonoBehaviour
{
    public GameObject black_One, black_Two;
    public GameObject white_One, white_Two;

    

    bool originalColor;

    // Start is called before the first frame update
    void Start()
    {
        originalColor = true;
        InvokeRepeating("ChangeTiles", 2.5f, 5f);
    }

    void ChangeTiles()
    {
        if (originalColor)
        {
            black_One.GetComponent<Tilemap>().color = Color.white;
            black_One.layer = 11;
            black_Two.GetComponent<Tilemap>().color = Color.white;
            black_Two.layer = 11;
            white_One.GetComponent<Tilemap>().color = Color.black;
            white_One.layer = 10;
            white_Two.GetComponent<Tilemap>().color = Color.black;
            white_Two.layer = 10;
            originalColor = false;
        }
        else if (!originalColor)
        {
            black_One.GetComponent<Tilemap>().color = Color.black;
            black_One.layer = 10;
            black_Two.GetComponent<Tilemap>().color = Color.black;
            black_Two.layer = 10;
            white_One.GetComponent<Tilemap>().color = Color.white;
            white_One.layer = 11;
            white_Two.GetComponent<Tilemap>().color = Color.white;
            white_Two.layer = 11;
            originalColor = true;
        }
    }
}
