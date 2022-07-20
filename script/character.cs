using System.Collections.Generic;
using UnityEngine;


public class character : MonoBehaviour
{
    public GameController GameController;
    public HPbar HPbar;
    public Animation enemyani;
    public int level = 1;
    public bool male = true;
    public string namecharacter;

    public plotAccess plot;

    public class_of_char[] classs;
    public class_of_char Class;

    public List<Enemy> enemies;
    public Enemy currenttarget;

    public float HP, MP, Atk, Def;
    public float buffdmg = 1;

    public float maxHP, maxMP;

    public int power_magic, master_magic, intelligion, life, power_spirit, mastery_taijutsu;

    private void Awake()
    {

        //khoi tao ban dau 
        if (PlayerPrefs.GetInt("isNewGame") == 1)
        {
            namecharacter = PlayerPrefs.GetString("name");
            switch (PlayerPrefs.GetInt("classofchar"))
            {
                case 0:
                    {
                        Class = classs[0];
                        break;
                    }
                case 1:
                    {
                        Class = classs[1];
                        break;
                    }
                case 2:
                    {
                        Class = classs[2];
                        break;
                    }
                case 3:
                    {
                        Class = classs[3];
                        break;
                    }
                case 4:
                    {
                        Class = classs[4];
                        break;
                    }
                case 5:
                    {
                        Class = classs[5];
                        break;
                    }
            }


            power_magic = Class.power_magic;
            master_magic = Class.master_magic;
            intelligion = Class.intelligion;
            life = Class.life;
            power_spirit = Class.power_spirit;
            mastery_taijutsu = Class.mastery_of_taijutsu;



            GetComponentInChildren<SpriteRenderer>().sprite = (male) ? Class.malesprite : Class.femalesprite;
        }
        else
        {
            GameController.loadgame(PlayerPrefs.GetInt("keysave"));
        }

        maxHP = HP = life * 100 * level;
        maxMP = MP = (power_magic * 10 + power_spirit * 20) * level;
        Atk = power_magic * 20 + power_spirit * 10 + level * 10;
        Def = life * 3 + mastery_taijutsu * 5 + level;


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            askill1();
        }
    }
    private void FixedUpdate()
    {

    }

    public void askill1()
    {
        if (currenttarget != null)
            currenttarget.HP -= buffdmg * Class.skills[0].SkillTrigger(this);
    }
    public void askill2()
    {
        if (currenttarget != null)
            currenttarget.HP -= buffdmg * Class.skills[1].SkillTrigger(this);

    }
    public void askill3()
    {
        if (currenttarget != null)
            currenttarget.HP -= buffdmg * Class.skills[2].SkillTrigger(this);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            enemies.Add(collision.GetComponent<Enemy>());
            if (enemies.Count == 1)
            {
                currenttarget = enemies[0];
            }

            //enemyani.Play();
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            if (collision.GetComponent<Enemy>() == currenttarget)
            {
                changeTarget();
            }
            else
            {

            }
            enemies.Remove(collision.GetComponent<Enemy>());
        }
    }

    public void changeTarget()
    {
        if (enemies == null)
        {
            currenttarget = null;
            return;
        }
        else
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy != currenttarget)
                {
                    currenttarget = enemy;
                    return;
                }
            }
        }

    }
}
