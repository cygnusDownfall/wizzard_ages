using System.Collections.Generic;
using UnityEngine;

public class ThuycauNo : MonoBehaviour
{
    public float dmg;
    public float speed;
    public Transform target;
    public Animation Explode;
    List<Enemy> enemies;
    private void Start()
    {
        enemies = new List<Enemy>();
       
    }
    private void Update()
    {
        if (transform.position == target.position)
        {
            explode();
        }
        else
        {
            //bug
            transform.Translate(target.position*Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            enemies.Add(collision.gameObject.GetComponent<Enemy>());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            enemies.Remove(collision.gameObject.GetComponent<Enemy>());
        }
    }
    public void explode()
    {
        //play  animations

        //caculate dmg
        foreach(Enemy enemy in enemies)
        {
            enemy.HP -= dmg;
        }
        //destroy this
        Destroy(this.gameObject);
        
    }
}
