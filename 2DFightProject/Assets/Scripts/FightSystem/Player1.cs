using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour,IPlayer
{
    public string Name { get { return name; } set { name = value; } }

    private string name="Player1";

   public IFightStep[] fightStep = new IFightStep[5];
    private void Start()
    {
        
    }

   
    private void Update()
    {
        
    }
}
