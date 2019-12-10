using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMoveLuigi : MonoBehaviour
{
    public float etageLuigi = 1;



    void Start()
    {

    }
    void Update()
    {
        MoveMario();
    }

    void MoveMario()
    {
        bool down = Input.GetKeyDown(KeyCode.Z);
        bool up = Input.GetKeyDown(KeyCode.S);
        if (down)
        {
            if (etageLuigi < 3)
            {
                etageLuigi++;
                Debug.Log("etageluigi=" + etageLuigi);
            }
        }
        if (up)
        {
            if (etageLuigi > 1)
            {
                etageLuigi--;
                Debug.Log("etageluigi=" + etageLuigi);
            }
        }
    }
}
