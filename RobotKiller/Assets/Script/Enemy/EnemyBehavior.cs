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


    public float EnemyDamage = 10f;
    public float EnemyRange = 100f;
    public GameObject EnemyGun;

    public float fireRate = 15f;
    private float nextTimeToFire = 0f;

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
            Hunted();   
        }
    }

    void Hunted() 
    {
        agent.destination = player.position;
        if (Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 3f / fireRate;
            ShootingAtPlayer();
        }
        

    }

    void ShootingAtPlayer()
    {
        RaycastHit EnHit;


                if (Physics.Raycast(EnemyGun.transform.position,
                EnemyGun.transform.forward, out EnHit, EnemyRange))
                {
                Debug.Log("Enemy" + EnHit.transform.name);
                }
                
    }
}
