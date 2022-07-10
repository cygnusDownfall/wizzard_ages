using System;
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float HP,maxHP,MaxMP, MP, atk;
    public kindofenemy kindenemy;
    public HPbar HPbar;
    public bool attackstate = false;
    public character character;
    
    private void Awake()
    {
        HP = kindenemy.HP;
        MP = kindenemy.MP;
        atk = kindenemy.atk;
    }
    public IEnumerator attack()
    {
        while (attackstate)
        {
            character.HP -= atk;
            character.HPbar.setHP();
            //Debug.Log("cccc");
            yield return new WaitForSeconds(2f);
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


}


