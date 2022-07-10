
using UnityEngine;

public class settingbarBehavier : MonoBehaviour
{
    public GameObject detail;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            detail.SetActive(false);
        }
    }
}
