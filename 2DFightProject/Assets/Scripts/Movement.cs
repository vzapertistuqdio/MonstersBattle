using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DirectionState { Left, Right };
public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D playerRgb;
  
    public  DirectionState state;

    private Animator anim;
    private void Start()
    {
        playerRgb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        if (state == DirectionState.Left)
            speed = -speed;
    }

   
    private void Update()
    {
        //playerRgb.velocity = Vector2.right * speed;
        Walk();
    }

    private void Walk()
    {
        playerRgb.velocity = Vector2.right * speed;
        if(speed!=0)
         anim.SetBool("isWalking",true);
        
    }
    public void StopWalk()
    {
        anim.SetBool("isWalking", false);
        speed = 0;
    }

    public DirectionState GetState()
    {
        return state;
    }
}
