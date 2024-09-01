using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
    private int i = 3;

    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.tag == "Blue" && i >= 150 && i <= 250)
        {
            int randomDisableTime = Random.Range(150, 251);
            if (i == randomDisableTime)
            {
                rend.enabled = false;
            }
        }
    }

}
