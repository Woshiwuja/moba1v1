using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    
    [field: SerializeField] private SampleScriptableObject Champion;
    ParticleSystem particleS;
    Vector3 mousePos;
        // Start is called before the first frame update
    void Start()
    {
        mousePos = Mouse.current.position.ReadValue();
        particleS = GetComponent<ParticleSystem>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.speed = Champion.MovementSpeed;
        string Name = Champion.Name;
        int HealthPoints = Champion.HealthPoints;
        //Debug.Log(HealthPoints); working
        int ManaPoints = Champion.ManaPoints;
        Debug.Log(mousePos);
        Debug.Log(agent.speed);
    
    }
    // Update is called once per frame
    void Update()
    {
        OnMove();
    }
    void OnMove()
    {
        RaycastHit hit;
        mousePos = Mouse.current.position.ReadValue();
        if(Mouse.current.rightButton.wasPressedThisFrame)
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(mousePos), out hit, Mathf.Infinity);
            Vector3 LookPosition = new Vector3(hit.point.x,this.transform.position.y, hit.point.z);
            transform.LookAt(LookPosition);
            agent.destination = hit.point;
        }
        //TODO SET STATUS TO MOVING
    }
}