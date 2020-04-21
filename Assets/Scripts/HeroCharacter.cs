using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HeroCharacter : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject target;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        agent.destination = target.transform.position;
    }
}
