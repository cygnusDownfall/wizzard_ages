
using UnityEngine;


[CreateAssetMenu(fileName = "enemy", menuName = "enemy")]

public class kindofenemy : ScriptableObject
{

    public int HP, atk;
    public virtual void movetoplayer(GameObject targetplayer, Rigidbody2D rigidbody, Transform vt)
    {

    }
}
