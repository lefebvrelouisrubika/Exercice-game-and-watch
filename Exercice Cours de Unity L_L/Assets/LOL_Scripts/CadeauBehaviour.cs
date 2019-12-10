using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadeauBehaviour : MonoBehaviour
{
    private float initCooldown = 0;
    [SerializeField]
    private float CooldownLenght;
    private float Cooldown;
    public float PositionCadeau;
    void Start()
    {
        Cooldown = initCooldown;
        PositionCadeau = 1;
    }

   

    void Update()
    {
        if (Cooldown < CooldownLenght)
        {
            Cooldown++;
        }
        else
        {
            Cooldown = initCooldown;
            PositionCadeau++;
            Debug.Log("position=" + PositionCadeau);
        }
    }
}
