using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownBlock : MonoBehaviour, IFightStep
{
    private IPlayer player;
    private void Start()
    {
        player = GetComponent<IPlayer>();
    }
    public void UseSkill()
    {
        Debug.Log(player.Name + " Использую нижний блок");
    }
}
