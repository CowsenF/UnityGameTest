using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    [SerializeField] private UnitScriptableObject unitInfo;

    private ArmyController armyGroup;



    private void UnitMover()
    {

        Vector2 randomPoint = Random.insideUnitCircle * armyGroup.army.radius;
        Vector3 RandomPoint = new Vector3(randomPoint.x, 0f, randomPoint.y);
        




    }

    public void SetArmyGroup(ArmyController newArmy)
    {
        this.armyGroup = newArmy;
    }
}
