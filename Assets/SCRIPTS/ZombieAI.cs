using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        player = GameObject.Find("Player_Object").transform;
        Debug.Log("Player found = " + player.name);
    }

    void Update()
    {
        agent.SetDestination(player.position);
    }
}