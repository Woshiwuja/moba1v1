using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnityChanSkills : MonoBehaviour
{
    [field: SerializeField] private SampleScriptableObject Champion;
    [field: SerializeField] public Skill SkillP;
    [field: SerializeField] public DashSkill Skill1;
    [field: SerializeField] public Skill Skill2;
    [field: SerializeField] public Skill Skill3;
    [field: SerializeField] public Skill Skill4;
    Vector3 mousePos;
    //cooldowns[i]-=Time.deltaTime

    //cooldowns declarations
    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePos = GetComponent<PlayerMovement>().mousePos;

    }

    // Update is called once per frame
    void Update()
    {
        OnSkill1();
    }

    void OnSkill1()
    {
        if(Keyboard.current.qKey.wasPressedThisFrame)
        {
            float totalDistance;
            RaycastHit hit;
            mousePos = Mouse.current.position.ReadValue();
            if(Physics.Raycast(Camera.main.ScreenPointToRay(mousePos), out hit, Mathf.Infinity))
            //Dash towards the hit point for a certain amount of units
            {
                Vector3 oldPosition = transform.position;
                Vector3 LookPosition = new Vector3(hit.point.x,this.transform.position.y, hit.point.z);
                transform.LookAt(LookPosition);
                GetComponent<UnityEngine.AI.NavMeshAgent>().destination = oldPosition +(hit.point - oldPosition).normalized * Skill1.range;
                GetComponent<UnityEngine.AI.NavMeshAgent>().speed = Skill1.speed;
                //move in a given direction for a given distance
                totalDistance = Vector3.Distance(oldPosition, hit.point);
                while(totalDistance > 0)
                {
                    totalDistance -= Time.deltaTime * Skill1.speed;
                    transform.position += transform.forward * Time.deltaTime * Skill1.speed;
                }
                GetComponent<UnityEngine.AI.NavMeshAgent>().speed = Champion.MovementSpeed;
            }
        }
    }
}

