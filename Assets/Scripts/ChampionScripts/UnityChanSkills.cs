using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnityChanSkills : MonoBehaviour
{

    [field: SerializeField] public Skill SkillP;
    [field: SerializeField] public DashSkill Skill1;
    [field: SerializeField] public Skill Skill2;
    [field: SerializeField] public Skill Skill3;
    [field: SerializeField] public Skill Skill4;
    
    // int[] range = new int[5]{};
    // float[] baseCoolDown = Skill1.baseCoolDown;
    //cooldowns[i]-=Time.deltaTime

    //cooldowns declarations
    // Start is called before the first frame update
    void Start()
    {
        int level = GetComponent<Level>().championLevel;
        // for(int i=0; i <= 5; i++)
        // {
        //     range[];
        // }
    }

    // Update is called once per frame
    void Update()
    {
        OnSkill1();
    }

    void OnSkill1()
    {
    }
}

