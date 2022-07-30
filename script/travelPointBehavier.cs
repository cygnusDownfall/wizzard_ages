using System.Collections;
using UnityEngine;

public class travelPointBehavier : MonoBehaviour
{
    public int waitfortravel=3;
    int currenttime = 0;
    public Transform targettravel;
    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            StartCoroutine("counttime");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            if (currenttime == waitfortravel)
            {
                travel(collision.gameObject);
            }
        }
           
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            StopCoroutine("counttime");
            currenttime = 0;
        }

    }
    IEnumerator counttime()
    {
        while (currenttime < waitfortravel)
        {
            currenttime++;
            yield return new WaitForSeconds(1);
        }
    }
    void travel(GameObject player)
    {
        player.transform.position = targettravel.position;
    }
}
