using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Block> path;

    void Start() {
        PrintAllWayPoints();
    }

    private void PrintAllWayPoints()
    {
        foreach (Block waypoint in path)
        {
            Debug.Log(waypoint.name);
        }
    }

    void Update() {
        
    }
}
