using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Scriptable Objects/Skills/Dash")]

public class DashSkill : Skill
{
    public int[] range = {600, 600, 600, 600, 600};
    public int[] speed = {200, 250, 300, 400, 500};
}
