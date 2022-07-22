using UnityEngine;

public class Skill : ScriptableObject
{
    public string skillName = "New Skill";
    public Sprite skillSprite;
    public string skillTooltip ="placeholder";
    public float[] skillCoolDown = {10.0f, 10.0f, 10.0f, 10.0f, 10.0f};
    public int skillLevel; //always starts at 0, lvl up only if CTRL + SKILL KEY and LVL UP points avaiable
}