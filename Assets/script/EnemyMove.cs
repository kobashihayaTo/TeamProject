using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{

    public Transform[] goals;

    private int destNum = 0;

    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();

        agent.destination = goals[destNum].position;
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance < 0.1f)
        {
            NextGoal();
        }
    }

    void NextGoal()
    {
        destNum += 1;

        if(destNum == 3)
        {
            destNum = 0;
        }

        agent.destination = goals[destNum].position;

        Debug.Log(destNum);
    }
}
