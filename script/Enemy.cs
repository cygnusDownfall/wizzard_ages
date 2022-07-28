
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // thao t�c 
    public GameObject HPcurrnentUI;
    public character character;
    public Animator Animator;

    //thu?c t�nh ch�nh 
    public float HP, maxHP,  atk;
    public float rangeAttack=2;
    public kindofenemy kindenemy;
   
    
    Rigidbody2D rigidbody2d;
    private void Update()
    {
        
        if (HP != maxHP)
        {
            
            if (HP <= 0)
            {
                updateHPUI(5);
                OnDie();
            }else
            updateHPUI((maxHP - HP) * 5 / maxHP);
            
        }
       //attack();

    }
    void OnDie()
    {
        Animator.SetBool("Die",true);
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
        while(true)
        {

            kindenemy.movetoplayer(character.gameObject, rigidbody2d, transform);
            if (Mathf.Abs(character.transform.position.x - transform.position.x) <= rangeAttack)
            {
                

                //chay animation attack

                //tinh dmg
                character.takedmgEvent(atk);
            }
            //StartCoroutine( impactskill.delay(1));
           
            yield return new WaitForSeconds(1);
        }

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            Animator.SetBool("beattacked", true);
            StartCoroutine("attack");
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Animator.SetBool("beattacked",false);
            StopCoroutine("attack");
        }
    }

    public void Reset()
    {
        HP = maxHP;
        updateHPUI(0);
        Animator.SetBool("Die", false);
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


