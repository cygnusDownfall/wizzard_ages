
using UnityEngine;

public class Thuattrilieu : skill
{
    public override float SkillTrigger(character character)
    {
        base.SkillTrigger(character);
        switch (lv)
        {
            case 1:
                {
                    return cap1(character.Atk, character);

                }
            case 2:
                {
                    return cap2(character.Atk, character);

                }
            case 3:
                {
                    return cap3(character.Atk, character);
                    //break;
                }
            case 4:
                {
                    return cap4(character.Atk, character);
                    // break;
                }
            case 5:
                {

                    return cap5(character.Atk, character);
                    //break;
                }
            case 6:
                {
                    return cap6(character.Atk, character);
                    // break;
                }
        }
        Debug.LogError("level khong hop le");
        return 0;

    }
    public float cap1(float atk, character character)
    {
        return 0;
    }
    public float cap2(float atk, character character)
    {
        return 0;
    }
    public float cap3(float atk, character character)
    {
        return 0;
    }
    public float cap4(float atk, character character)
    {
        return 0;
    }
    public float cap5(float atk, character character)
    {
        return 0;
    }
    public float cap6(float atk, character character)
    {
        return 0;
    }
}
