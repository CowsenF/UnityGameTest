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
            GameObject newUnit = Instantiate(army.unit, transform.position, Quaternion.identity);
            newUnit.GetComponent<UnitController>().SetArmyGroup(this);
            CombatGameManager.instance.AddNewUnit(newUnit); //add new unit to a global list 
        }
    }
    //Spawn army

    //set desiredPosition

}
