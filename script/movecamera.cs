
using UnityEngine;

public class movecamera : MonoBehaviour
{
   
    [SerializeField] GameObject player;
    void LateUpdate()
    {
        this.gameObject.transform.position = player.transform.position;
    }
}
