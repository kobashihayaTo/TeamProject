using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public GameObject goal;

    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        goal = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = goal.transform.position;
    }
}
