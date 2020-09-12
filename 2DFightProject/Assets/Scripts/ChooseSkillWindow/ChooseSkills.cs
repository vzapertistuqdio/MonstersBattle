using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSkills : MonoBehaviour
{
    private bool flag=true;
    private int index=0;
    [SerializeField] private Text[] player1SkillText;

    private Text currentText;

    //1 UpBlock
    //2 DownBlock
    //3 UpAttack
    //4 DownAttack
    private void Awake()
    {
        currentText = player1SkillText[index];
    }
    private void Start()
    {
        
    }

    
    private void Update()
    {
        if (player1SkillText.Length > index)
            currentText = player1SkillText[index];
        if (index == 5 && flag)
        {
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(PlayerPrefs.GetInt("step" + i));
                flag = false;
            }
        }


    }

    public void OnUseBlockUp()
    {
        int skillNumber = 1;
        SaveSkill(skillNumber);
        currentText.text = "Верхний блок";
        index++;
      
    }
    public void OnUseBlockDown()
    {
        int skillNumber = 2;
        SaveSkill(skillNumber);
        currentText.text = "Нижний блок";
        index++;
     
    }
    public void OnUseAttackUp()
    {
        int skillNumber = 3;
        SaveSkill(skillNumber);
        currentText.text = "Верхняя атака";
        index++;
     
    }
    public void OnUseAttackDown()
    {
        int skillNumber = 4;
        SaveSkill(skillNumber);
        currentText.text = "Нижняя атака";
        index++;
     
    }

    private void SaveSkill(int skillNumber)
    {
        PlayerPrefs.SetInt("step" + index, skillNumber);
    }
}
