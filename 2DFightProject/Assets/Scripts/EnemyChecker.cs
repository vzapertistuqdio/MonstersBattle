using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChecker : MonoBehaviour
{
    private Ray2D rayChecker;
    private RaycastHit2D hit;

    private bool fightIsStarted=false;

   [SerializeField] private LayerMask enemy;
    [SerializeField] private float distance;

    private Vector2 direction;

    private Movement playerMoveScript;
    private IFight playerFightScript;

    private void Start()
    {
        playerMoveScript = GetComponent<Movement>();
        playerFightScript = GetComponent<IFight>();
        direction = SetRayDirection(playerMoveScript.GetState());
    }


    private void Update()
    {
      
        if (Physics2D.Raycast(transform.position, direction,distance,enemy))
        {
            playerMoveScript.StopWalk();
            if (fightIsStarted == false)
            {
                StartFight();
            }
            
        }
    }


    private Vector2 SetRayDirection(DirectionState state)
    {
        if (state == DirectionState.Left)
            return Vector2.left;
        else if (state == DirectionState.Right)
            return Vector2.right;
        else return Vector2.zero;
    }
    private void StartFight()
    {
        playerFightScript.StartFight();
        fightIsStarted = true;
    }

}

    
