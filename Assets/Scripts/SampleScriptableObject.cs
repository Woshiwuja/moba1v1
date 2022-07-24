using UnityEngine;

[CreateAssetMenu(menuName="Scriptable Objects/Champion")]

public class SampleScriptableObject : ScriptableObject
{
    public string Name = "PLACEHOLDER";
    public int MovementSpeed = 10;
    public int AttackDamage = 80;
    public int Range = 125;
    public int SkillPower = 0;
    public int HealthPoints = 400;
    public int ManaPoints = 100;
    public int Armor = 10;
    public int MagicResist = 10;
    public float AttackSpeed = 0.7f;
    public float CooldownReduction = 0f;
    public float ArmorPenetration = 0f;
    public float MagicPenetration = 0f;
    
    public void Awake()
    {

    }
    public void OnEnable()
    {

    }
    public void OnDisable()
    {

    }
    public void OnDestroy()
    {

    }
}