using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    
    [field: SerializeField] private SampleScriptableObject Champion;
    // Start is called before the first frame update
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.speed = Champion.MovementSpeed;
        string Name = Champion.Name;
        int HealthPoints = Champion.HealthPoints;
        //Debug.Log(HealthPoints); working
        int ManaPoints = Champion.ManaPoints;
        Debug.Log(Name);
        Debug.Log(agent.speed);
    
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;  
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
            transform.LookAt(hit.point);
            agent.destination = hit.point;
            }
        }        
    }
}
