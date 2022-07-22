using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int currentXP = 0;
    public int targetXP;
    public int championLevel = 1;
    public int skillPoints = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(targetXP<=currentXP)
        {
            LevelUp();
            currentXP -= targetXP;
            targetXP = 300;
        }
    }
    void LevelUp()
    {
        championLevel++;
        skillPoints++;
    }
}
