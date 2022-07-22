
using UnityEngine;
[CreateAssetMenu(fileName ="smile",menuName ="smile")]

public class smile : kindofenemy
{
    
    override public void movetoplayer(GameObject targetplayer,Rigidbody2D rigidbody,Transform vt)
    {
        float iF = targetplayer.transform.position.x - vt.position.x;
        if(iF<0)
        {
            vt.localScale = new Vector3(-1, 1, 1);
            rigidbody.AddForce(new Vector3(-50, 100));
        }
        else
        {
            vt.localScale = new Vector3(1, 1, 1);
            rigidbody.AddForce(new Vector3(50, 100));
        }
       
    }
  
    
}
