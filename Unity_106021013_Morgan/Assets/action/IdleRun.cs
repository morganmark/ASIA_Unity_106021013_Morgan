using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleRun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RunAndIdle();
        Jump();
        Jumping();
    }

    public Animator ani;
    private void RunAndIdle()
    {
        //print(Input.GetAxis("Horizontal"));
        //print(Input.GetAxis("Vertical"));

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        ani.SetBool("IdleToRun", h != 0 || v != 0);
    }
    private void Jump()
    {
        ani.SetBool("IdleToJump", Input.GetKeyDown(KeyCode.Space));
        ani.SetBool("IdleToJump", Input.GetKeyUp(KeyCode.Space));
    }
    private void Jumping()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        ani.SetBool("RunningToJumping", Input.GetKeyDown(KeyCode.Space)&& (h != 0 || v != 0));
    }

}
