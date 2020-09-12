using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpBlock : MonoBehaviour, IFightStep
{
    private IPlayer player;
    private void Start()
    {
        player = GetComponent<IPlayer>();
    }
    public void UseSkill()
    {
        Debug.Log(player.Name+" Использую верхний блок");
    }
}
