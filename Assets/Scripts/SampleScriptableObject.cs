using UnityEngine;

[CreateAssetMenu(menuName="Scriptable Objects/Champion")]

public class SampleScriptableObject : ScriptableObject
{
    public string Name = "PLACEHOLDER";
    public int MovementSpeed = 10;
    public int HealthPoints = 100;
    public int ManaPoints = 100;
    public int Armor = 10;
    public int MagicResist = 10;
    public int Experience = 0;
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