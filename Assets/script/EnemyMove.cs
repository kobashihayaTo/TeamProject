using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{

    //巡回地点を格納する場所
    public Transform[] goals;

    private int destNum = 0;

    private int randomPatrol = 0;

    public NavMeshAgent agent;

    [SerializeField]
    private SearchCollision searchCollision;

    // Start is called before the first frame update
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();

        agent.destination = goals[destNum].position;

        //randomPatrol = destNum;
    }

    // Update is called once per frame
    void Update()
    {
        if (searchCollision.GetSearchFlag() == false)
        {
            if (agent.remainingDistance < 0.1f)
            {
                NextGoal();
            }
        }
        
    }

    //巡回地点についたら新しい巡回地点に向かう
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
