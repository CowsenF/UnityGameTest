using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyController : MonoBehaviour
{
    public ArmyScriptableObject army;

    [SerializeField] private Vector3 desiredPosition;

    private void Awake()
    {
        SpawnArmy();
    }
    public void SpawnArmy()
    {
        for (int i = 0; i < army.numberOfUnits; i++)
        {

        }
    }
    //Spawn army

    //set desiredPosition

}
