using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMoveMario : MonoBehaviour
{

    public float etageMario = 1;
    


    void Start()
    {
        
    }
    void Update()
    {
        MoveMario();
    }

    void MoveMario()
    {
        bool down = Input.GetKeyDown(KeyCode.UpArrow);
        bool up = Input.GetKeyDown(KeyCode.DownArrow);
        if (down)
        {
            if (etageMario < 3)
            {
                etageMario++;
                Debug.Log("etagemario=" + etageMario);
            }
        }
        if (up)
        {
            if (etageMario > 1)
            {
                etageMario--;
                Debug.Log("etagemario=" + etageMario);
            }
        }
    }
}

   