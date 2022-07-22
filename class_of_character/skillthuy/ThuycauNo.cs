
using System.Collections.Generic;
using UnityEngine;

public class ThuycauNo : MonoBehaviour
{
    public float dmg;
    public int lv;
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
        Vector2 move = target.position-transform.position ;
        transform.Translate(move* Time.deltaTime*speed);
        if (Mathf.Abs(transform.position.x - target.position.x) < 1)
        {
            explode();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");
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
        if (lv>=5)
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.HP -= dmg;
            }
        }
        
        //caculate dmg
        
        //destroy this
        Destroy(this.gameObject);

    }
  
}
