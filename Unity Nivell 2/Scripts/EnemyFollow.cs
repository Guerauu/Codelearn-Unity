using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniyEngine.AI

public class EnemyFollow : MonoBehaviour
{


    public UnityEngine.AI.NavMeshAgent enemy;
    public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
    }
}
