
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject HPcurrnentUI;
    public float HP, maxHP,  atk;
    public float rangeAttack=2;
    public kindofenemy kindenemy;
    public bool attackstate = false;
    public character character;
    Rigidbody2D rigidbody2d;
    private void Update()
    {
        if (HP != maxHP)
        {
            updateHPUI((maxHP - HP) * 5 / maxHP);

        }
        

    }

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        maxHP = kindenemy.HP;
        HP = kindenemy.HP;
        atk = kindenemy.atk;
    }
    public IEnumerator attack()
    {
        while (attackstate)
        {

            kindenemy.movetoplayer(character.gameObject, rigidbody2d, transform);
            if (Mathf.Abs(character.transform.position.x - transform.position.x) <= rangeAttack)
            {
                //chay animation attack

                //tinh dmg
                character.takedmgEvent(atk);
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

    public void Reset()
    {
        HP = maxHP;
        updateHPUI(0);
    }

    void updateHPUI(float X)
    {
        HPcurrnentUI.transform.localScale =new Vector3(X,1,1);
        if (HP < maxHP*70 / 100 )
        {
            Debug.Log(HP);
            HPcurrnentUI.GetComponent<SpriteRenderer>().color = new Color(255, 160, 0);
        }else if (HP < maxHP*30 / 100 )
        {
            HPcurrnentUI.GetComponent<SpriteRenderer>().color = new Color(255,0, 0);
        }else
        {
           
            HPcurrnentUI.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0);
        }
    }

}


