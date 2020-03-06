using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TMovement : MonoBehaviour
{
    public float moveSpeed;
    public Transform[] points;
    private int destPoint;
    private NavMeshAgent agent;


    // Start is called before the first frame update
    void GoToNextPoint()
    {
        if (points.Length == 0)
            return;
        agent.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        GoToNextPoint();
    }


    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GoToNextPoint();
    }
}
