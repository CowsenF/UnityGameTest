using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitMotor : MonoBehaviour
{
    private Vector3 target = new();
    private NavMeshAgent agent;
    private ArmyController armyGroup;

    [SerializeField] private float minInterval = 3f;
    [SerializeField] private float maxInterval = 40f;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        agent.updateRotation = false;
        UnitMover();
        StartCoroutine(RandomMovement());
    }

    public void SetArmyGroup(ArmyController newArmy)
    {
        this.armyGroup = newArmy;
    }

    private void UnitMover()
    {

        Vector2 randomPoint = Random.insideUnitCircle;
        Vector3 RandomPoint = new(randomPoint.x * armyGroup.army.radius, 0f, randomPoint.y * armyGroup.army.radius);

        target = armyGroup.transform.position + RandomPoint;
        agent.SetDestination(target);
    }

    private void Update()
    {

        if (agent.remainingDistance > agent.stoppingDistance)
        {
            Vector3 targetDirection = target - transform.position;
            float angle = Vector3.Angle(transform.forward, targetDirection);
            float desiredRotationAngle = Mathf.Round(angle / 45) * 45;
            Quaternion desiredRotation = Quaternion.Euler(0, desiredRotationAngle, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, agent.angularSpeed * Time.deltaTime);
        }
    }

    IEnumerator RandomMovement()
    {
        while (true)
        {
            float waitTime = Random.Range(minInterval, maxInterval);
            yield return new WaitForSeconds(waitTime);

            UnitMover();
        }
    }
}
