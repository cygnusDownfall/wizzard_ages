using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    public bool player;
    public Slider Slider;
    public character character;
    public Enemy Enemy;
    public void Start()
    {
        setMaxHPs();
        
    }
    public void setMaxHPs()
    {
        if (player)
        {
            Slider.maxValue = character.maxHP;
            Slider.value = character.maxHP;
        }
        else
        {
            Slider.maxValue = Enemy.maxHP;
            Slider.value = Enemy.maxHP;
        }

    }
    public void setHP()
    {
        if (player)
        {
            Slider.value = character.HP;
        }
        else
        {
            Slider.value = Enemy.HP;
        }
    }
}


