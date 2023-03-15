using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Transform playerTransform;
    private Vector3 targetDir;
    public NavMeshAgent nav;

    public EnemyNavMesh enemyNavMesh;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (enemyNavMesh.isChasingPlayer == true)
        {
            float playerDistance = Vector3.Distance(transform.position, playerTransform.position);
            nav.SetDestination(playerTransform.position);
            if (playerDistance >= enemyNavMesh.range)
            {
                enemyNavMesh.isPatrolling = true;
                enemyNavMesh.isChasingPlayer = false;
            }
        }
    }
}
