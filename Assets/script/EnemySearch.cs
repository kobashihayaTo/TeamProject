using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySearch : MonoBehaviour
{
    [SerializeField]
    private SearchCollision searchCollision;

    private NavMeshAgent navMeshAgent;

    [SerializeField]
    private GameObject player;

    private void Start()
    {
        //NavMeshAgent�R���|�[�l���g��擾
        navMeshAgent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (searchCollision.GetSearchFlag() == true)
        {
            // �Ώۂ̃I�u�W�F�N�g��ǂ�������
            navMeshAgent.destination = player.transform.position;
            Debug.Log(navMeshAgent.destination);
        }
    }
}
