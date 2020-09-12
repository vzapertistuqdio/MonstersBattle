using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour,IPlayer
{
    public string Name { get { return name; } set { name = value; } }

    private string name="Player2";

    public IFightStep[] fightStep = new IFightStep[5];
    private void Start()
    {
        
    }

    
    private void Update()
    {
        
    }
}
