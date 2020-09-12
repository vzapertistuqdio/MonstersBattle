using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    private void Start()
    {
        FightSystem.GetInstance().Player1.fightStep[0] = FightSystem.GetInstance().Player1.GetComponent<UpBlock>();
        FightSystem.GetInstance().Player1.fightStep[1] = FightSystem.GetInstance().Player1.GetComponent<DownBlock>();
        FightSystem.GetInstance().Player1.fightStep[2] = FightSystem.GetInstance().Player1.GetComponent<UpAttack>();
        FightSystem.GetInstance().Player1.fightStep[3] = FightSystem.GetInstance().Player1.GetComponent<DownAttack>();
        FightSystem.GetInstance().Player1.fightStep[4] = FightSystem.GetInstance().Player1.GetComponent<UpAttack>();
        FightSystem.GetInstance().Player1.fightStep[0].UseSkill();
        FightSystem.GetInstance().Player1.fightStep[1].UseSkill();
        FightSystem.GetInstance().Player1.fightStep[2].UseSkill();
        FightSystem.GetInstance().Player1.fightStep[3].UseSkill();
        FightSystem.GetInstance().Player1.fightStep[4].UseSkill();
    }

    
    private void Update()
    {
        
    }
}
