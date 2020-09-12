using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownAttack : MonoBehaviour, IFightStep
{
    private IPlayer player;
    private void Start()
    {
        player = GetComponent<IPlayer>();
    }
    public void UseSkill()
    {
        Debug.Log(player.Name + " Использую нижнюю атаку");
    }
}
