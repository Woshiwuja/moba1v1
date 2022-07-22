using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnityChanSkills : MonoBehaviour
{
    Vector3 championPosition;
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
        Vector3 mousePos = GetComponent<PlayerMovement>().mousePos;
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
        RaycastHit hit;
        mousePos = Mouse.current.position.ReadValue();
        if(Keyboard.current.qKey.wasPressedThisFrame)
        {
            if(Physics.Raycast(Camera.main.ScreenPointToRay(mousePos), out hit, Mathf.Infinity) && Math.Round(Vector3.Distance(transform.position,hit.point))<=Skill1.range)
            {
                Vector3 LookPosition = new Vector3(hit.point.x,this.transform.position.y, hit.point.z);
                transform.LookAt(LookPosition);
                transform.Translate(Vector3.forward * Time.deltaTime * Skill1.speed, hit.point);
            }
        }
    }
}

