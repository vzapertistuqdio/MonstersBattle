using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightSystem : MonoBehaviour
{
    public Player1 Player1 { get { return player1; } private set { } }
    public Player2 Player2 { get { return player2; } private set { } }

    private Player1 player1;
    private Player2 player2;


    private static FightSystem _fightSytem;
    private FightSystem() { }

    public static FightSystem GetInstance()
    {
        return _fightSytem;
    }
    private void Awake()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Player1>();
        player2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Player2>();
        _fightSytem = GetComponent<FightSystem>();
    }
    private void Start()
    {
     
    }

   
    private void Update()
    {
        
    }
}
