using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class BotMovement : MonoBehaviour
{
    public GameObject platform;
    public GameObject finish;
    bool crossed = false;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = platform.transform.position;
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position, agent.destination) < 5f)
        {
            agent.destination = finish.transform.position;
            crossed = true;
        }
        if (!crossed)
        {
            agent.destination = platform.transform.position;
        }

    }
}
