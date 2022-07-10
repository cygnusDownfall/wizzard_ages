
using UnityEngine;


// chi dung cho active skill 
public class skill : ScriptableObject
{
    public int lv, cd, manacost, lvcanthiet, atktimes;
    [TextArea] public string decripe;
    public Sprite imgskill;
    public Animation playerani;
    public virtual float SkillTrigger(character character)
    {
        
        //chay animations
        //playerani.Play();
        
        return 0;
    }
    public virtual void levelup()
    {
        lv++;
    }
}

/*

//[CreateAssetMenu(fileName = "thanhluu", menuName = "thanhluu")]
class Thanhluu : skill
{
    public void cap1()
    {

    }
    public void cap2()
    {

    }
    public void cap3()
    {

    }
    public void cap4()
    {

    }
    public void cap5()
    {

    }
    public void cap6()
    {

    }
}
//[CreateAssetMenu(fileName = "thuattrilieu", menuName = "thuattrilieu")]
class Thuattrilieu : skill
{
    public void cap1()
    {

    }
    public void cap2()
    {

    }
    public void cap3()
    {

    }
    public void cap4()
    {

    }
    public void cap5()
    {

    }
    public void cap6()
    {

    }
}
//[CreateAssetMenu(fileName = "thuycau", menuName = "skill")]
class Dongnuocchaysiet : skill
{
    public void cap1()
    {

    }
    public void cap2()
    {

    }
    public void cap3()
    {

    }
    public void cap4()
    {

    }
    public void cap5()
    {

    }
    public void cap6()
    {

    }
}
//[CreateAssetMenu(fileName = "thuycau", menuName = "skill")]
class Muamathuat : skill
{
    public void cap1()
    {

    }
    public void cap2()
    {

    }
    public void cap3()
    {

    }
    public void cap4()
    {

    }
    public void cap5()
    {

    }
    public void cap6()
    {

    }
}
//[CreateAssetMenu(fileName = "thuycau", menuName = "skill")]
class Thuythangiangthe : skill
{

}
//[CreateAssetMenu(fileName = "thuycau", menuName = "skill")]
class Caubang : skill
{

}
*/