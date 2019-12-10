using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEtagereaactiver : MonoBehaviour
{
    public bool rezDechaussee;
    public bool permierEtage;
    public bool deuxiemeEtage;
    public bool troisiemeEtage;
    public bool quatriemeEtage;
    public bool cinquiemeEtage;
    public bool position1;
    public bool position2;
    public bool position3;
    public bool position4;
    public bool position5;
    public bool position6;
    public bool position7;
    public bool position8;
    private float positionCadeau;
    
    void Start()
    {
        positionCadeau = CadeauBehaviour.PositionCadeau;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
