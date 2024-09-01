using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    // Start is called before the first frame update
    private int i = 3;
    public Renderer rend;

    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
    }

}
