using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    public Transform player;

    public Transform patrolRoute;

    public List<Transform> location;

    public int locationIndex = 0;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        player = GameObject.Find("Player").transform;

        InitializePatrolRoute();

        MoveToNextPatrolLocation();
    }

    void Update()
    {
        if(agent.remainingDistance < 0.2f && !agent.pathPending)
        {
            MoveToNextPatrolLocation();
        }
    }

    void InitializePatrolRoute()
    {
        foreach(Transform child in patrolRoute)
        {
            location.Add(child);
        }
    }

    void MoveToNextPatrolLocation()
    {
        if (location.Count == 0)
            return;

        agent.destination = location[locationIndex].position;

        locationIndex = (locationIndex + 1) % location.Count;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.name == "Player")
        {
            agent.destination = player.position;

            Debug.Log("Enemy detected!");
        }
    }


}
