using UnityEngine;

public class nenmenuController : MonoBehaviour
{
    public GameObject cloud;
    GameObject currentcloud;
    private void Start()
    {
        SpawnCloud();
    }
    private void Update()
    {
        currentcloud.transform.Translate(new Vector3(1, 0, 0));
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "cloud")
        {
            Destroy(collision.gameObject);
            SpawnCloud();
        }
    }
    void SpawnCloud()
    {
        currentcloud = Instantiate(cloud, GameObject.FindGameObjectWithTag("spawnClouds").transform);
        currentcloud.tag = "cloud";
    }
}
