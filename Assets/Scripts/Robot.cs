using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
    [SerializeField]
    private string robotType;

    public int health;
    //the range that the robot can fire from
    public int range;
    public float fireRate;

    //where to fire the missile from
    public Transform missleFireSpot;
    public NavMeshAgent agent;

    private Transform player;
    private float timeLastFired;

    private bool isDead;

    public Animator robot;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;
        }

        transform.LookAt(player);
        agent.SetDestination(player.position);

        if(Vector3.Distance(transform.position, player.position) < range && Time.time - timeLastFired > fireRate)
        {
            timeLastFired = Time.time;
            Fire();
        }
    }

    private void Fire()
    {
        robot.Play("Fire");
    }
}
