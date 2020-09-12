using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight2 : MonoBehaviour,IFight
{
    private Animator playerAnim;

    private void Start()
    {
        playerAnim = GetComponent<Animator>();
    }


    private void Update()
    {

    }

    public void UseUpAttack()
    {
        playerAnim.SetBool("isUpAttack", true);
        StartCoroutine(DisableAnimAfterTime(0.1f, "isUpAttack"));
    }
    public void UseDownAttack()
    {
        playerAnim.SetBool("isDownAttack", true);
        StartCoroutine(DisableAnimAfterTime(0.25f, "isDownAttack"));
    }

    public void UseUpBlock()
    {
        playerAnim.SetBool("isUpBlock", true);
        StartCoroutine(DisableAnimAfterTime(0.3f, "isUpBlock"));
    }
    public void UseDownBlock()
    {
        playerAnim.SetBool("IsDownBlock", true);
        StartCoroutine(DisableAnimAfterTime(0.3f, "IsDownBlock"));
    }
    public void Dyiing()
    {
        playerAnim.SetBool("isDead", true);
    }

    public void StartFight()
    {
        StartCoroutine(StartFightWithDelay());
    }
    private IEnumerator DisableAnimAfterTime(float time, string animName)
    {
        yield return new WaitForSeconds(time);
        playerAnim.SetBool(animName, false);
    }
    private IEnumerator StartFightWithDelay()
    {
        //yield return new WaitForSeconds(0.1f);
        UseDownBlock();
        yield return new WaitForSeconds(1f);
        Dyiing();


    }
}
