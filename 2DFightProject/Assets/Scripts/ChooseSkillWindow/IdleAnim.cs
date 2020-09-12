using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAnim : MonoBehaviour
{
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isIdle",true);
            
    }

  
    void Update()
    {
        
    }
}
