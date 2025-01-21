using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowWaypoint : MonoBehaviour
{
    public GameObject wpManager;
    GameObject[] waypoints;
    GameObject currentNode;
    NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        waypoints = wpManager.GetComponent<WPManager>().waypoints;
        currentNode = waypoints[0];
        Time.timeScale = 5;

        agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToRuin()
    {
        //g.AStar(currentNode, waypoints[3]);
        agent.SetDestination(waypoints[3].transform.position);
    }


    public void GoToHeli()
    {
        //g.AStar(currentNode, waypoints[13]);
        agent.SetDestination(waypoints[13].transform.position);
    }

    public void LateUpdate()
    {
     
    }
}
