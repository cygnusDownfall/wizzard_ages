
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject HPcurrnentUI;
    public float HP, maxHP, maxMP, MP, atk;
    public kindofenemy kindenemy;
    public bool attackstate = false;
    public character character;
    Rigidbody2D rigidbody2d;
    private void Update()
    {
        updateHPUI();

    }

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        maxHP = kindenemy.HP;
        HP = kindenemy.HP;
        MP = kindenemy.MP;
        maxMP = kindenemy.MP;
        atk = kindenemy.atk;
    }
    public IEnumerator attack()
    {
        while (attackstate)
        {

            kindenemy.movetoplayer(character.gameObject, rigidbody2d, transform);
            if (Mathf.Abs(character.transform.position.x - transform.position.x) < 1)
            {
                character.HP -= atk;
                character.HPbar.setHP();
            }
            
            //Debug.Log("cccc");
            yield return new WaitForSeconds(1);
        }

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {


            attackstate = true;

            //play animation attack 


            StartCoroutine(attack());



        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            attackstate = false;
            // Debug.Log("gfgfh");
            StopCoroutine(attack());
        }
    }

    void updateHPUI()
    {
        HPcurrnentUI.transform.localScale =new Vector3( (maxHP - HP) * 5 / maxHP,1,1);
        
    }

}


