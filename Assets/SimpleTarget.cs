using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleTarget : MonoBehaviour
{
    public List<Transform> goals;
    int numGoal;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(goals[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance <= agent.stoppingDistance)
        {
            agent.SetDestination(goals[numGoal].position);
            numGoal++;
            if (numGoal == goals.Count) numGoal = 0;
        }
    }
}
