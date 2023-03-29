using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float minCaptureDistance;

    private Transform playerTransform;

    public NavMeshAgent nav;
    public EnemyNavMesh enemyNavMesh;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private GameObject teleport;

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

            if(Vector3.Distance(transform.position, playerTransform.position) <= minCaptureDistance)
            {
                // Disable the cc
                characterController.enabled = false;
                // Move the cc
                Debug.Log("Player teleported");
                playerTransform.position = teleport.transform.position;
                // Enabled the cc
                characterController.enabled = true;
            }
        }
    }
}
