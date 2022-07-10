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
        if (transform.position == target.position)
        {
            explode();
        }
        else
        {
            //bug
            gameObject.GetComponent<Rigidbody2D>().velocity= Vector3.Lerp(target.position, transform.position, 1)*Time.deltaTime*speed ;
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
