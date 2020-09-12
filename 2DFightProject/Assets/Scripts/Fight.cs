using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fight : MonoBehaviour,IFight
{
    private Animator playerAnim;
    [SerializeField] private Slider enemySlider;
    
    private void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

  
   private void Update()
    {
        
    }

    public void UseUpAttack()
    {
        playerAnim.SetBool("isUpAttack",true);
        StartCoroutine(DisableAnimAfterTime(0.05f, "isUpAttack"));
    }
    public void UseDownAttack()
    {
        playerAnim.SetBool("isDownAttack", true);
        StartCoroutine(DisableAnimAfterTime(0.25f,"isDownAttack"));
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

    public void StartFight()
    {
        StartCoroutine(StartFightWithDelay());
    }
    private IEnumerator DisableAnimAfterTime(float time,string animName)
    {
        yield return new WaitForSeconds(time);
        enemySlider.value -= 0.5f;
        playerAnim.SetBool(animName, false);
    }
    private IEnumerator StartFightWithDelay()
    {
       
        UseUpAttack();
        yield return new WaitForSeconds(1f);
        UseUpAttack();
        yield return new WaitForSeconds(1f);
        

    }
}
