using UnityEngine;
using UnityEngine.UI;

public class statusbarController : MonoBehaviour
{
    
    public Slider HPs;
    public Slider MPs;
    public character character;
    public void Start()
    {
        setMaxHPs();
        setMaxMPs();
    }
    public void setMaxHPs()
    {
        HPs.maxValue = character.maxHP;
        HPs.value = character.maxHP;
        HPs.gameObject.GetComponentInChildren<TMPro.TMP_Text>().text = character.maxHP + "/" + character.maxHP;
    }
    public void setMaxMPs()
    {
        MPs.maxValue = character.maxMP;
        MPs.value = character.maxMP;
        MPs.gameObject.GetComponentInChildren<TMPro.TMP_Text>().text = character.maxMP + "/" + character.maxMP;
    }
    public void setHP()
    {
        HPs.value = character.HP;
        HPs.gameObject.GetComponentInChildren<TMPro.TMP_Text>().text = character.HP + "/" + character.maxHP;
        if (character.HP < character.maxHP * 70 / 100)
        {
            HPs.gameObject.GetComponentInChildren<Image>().color = new Color(255, 255, 0);
        }
        else if (character.HP < character.maxHP * 30 / 100)
        {
            Debug.Log("cam");
            HPs.gameObject.GetComponentInChildren<Image>().color = new Color(255,168, 0);
        }
        else
        {
            HPs.gameObject.GetComponentInChildren<Image>().color = new Color(0, 255, 0);
        }
    }
    public void setMP()
    {
        MPs.value = character.MP;
        MPs.gameObject.GetComponentInChildren<TMPro.TMP_Text>().text = character.MP + "/" + character.maxMP;
    }
}


