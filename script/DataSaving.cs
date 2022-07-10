
using UnityEngine;

[System.Serializable]
public class DataSaving
{
    public int plot;
    public int lv, power_magic, master_magic, intelligion, life, power_spirit, mastery_taijutsu;
    public float  HP, MP, Atk, Def;
    public string namecharacter;
    public float[] potitions;
    public DataSaving()
    {
        //khúc này k th? dùng khi ch?i online 
        character properties = GameObject.FindGameObjectWithTag("Player").GetComponent<character>();
        potitions = new float[3];

        plot=properties.plot.currentplot;

        lv = properties.level;
        power_magic = properties.power_magic;
        mastery_taijutsu = properties.mastery_taijutsu;
        master_magic = properties.master_magic;
        intelligion = properties.intelligion;
        life = properties.life;
        power_spirit = properties.power_spirit;

        namecharacter = properties.namecharacter;

        HP = properties.HP;
        MP = properties.MP;
        Atk = properties.Atk;
        Def = properties.Def;

        potitions[0] = properties.gameObject.transform.position.x;
        potitions[1] = properties.gameObject.transform.position.y;
        potitions[2] = properties.gameObject.transform.position.z;
    }
}

