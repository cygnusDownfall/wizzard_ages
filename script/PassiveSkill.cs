using UnityEngine;

public class PassiveSkill : ScriptableObject
{
    public int lv, lvcanthiet;
    [TextArea] public string[] decripe;

    
    
    public virtual void levelup()
    {
        lv++;
    }
}
