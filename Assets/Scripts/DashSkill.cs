using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Scriptable Objects/Skills/Dash")]

public class DashSkill : Skill
{
    public float range;
    public int speed;
    public float dashTime;
}
