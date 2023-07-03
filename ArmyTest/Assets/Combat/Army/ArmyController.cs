using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyController : MonoBehaviour
{
    public ArmyScriptableObject army;
    [SerializeField] private List<GameObject> units = new();


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
            newUnit.GetComponent<UnitMotor>().SetArmyGroup(this);
            CombatGameManager.instance.AddNewUnit(newUnit); //add new unit to a global list 
            units.Add(newUnit);
        }
    }
    //Spawn army

    public void SetNewPosition(Vector3 newPosition)
    {
        this.transform.position = newPosition;
        units.ForEach(unit => { unit.GetComponent<UnitMotor>().UnitMover(); });
    }

}
