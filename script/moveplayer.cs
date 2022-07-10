using UnityEngine;

public class moveplayer : MonoBehaviour
{
    charactercontroller controller;
    float horizontal;
    bool jump=false,crough=false;
    public void Start()
    {
        controller = GetComponent<charactercontroller>();
    }
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        jump = Input.GetButtonDown("Jump");
    }
    private void FixedUpdate()
    {
        controller.Move(horizontal,crough,jump);
    }
    public void moveright()
    {
        horizontal = 1;
       
    }
    public void moveleft()
    {
        horizontal = -1;
        
    }
    public void moveup()
    {
        jump = true;
    }


  
}
