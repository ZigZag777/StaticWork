using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public bool CanMove;
    public float PlayerSpeed;
    public float dx, dy;
    public Animator AnimController;

    public MoveController MoveController;
    // Start is called before the first frame update
    void Start()
    {
        CanMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (CanMove)
            {
                dirvelocity();
                MoveController.Move(dx, dy);
            }
    }

    void dirvelocity()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) + Mathf.Abs(Input.GetAxis("Vertical")) == 2)
        {
            dx = Input.GetAxis("Horizontal") * 0.7f * PlayerSpeed;
            dy = Input.GetAxis("Vertical") * 0.7f * PlayerSpeed;
        }
        else
        {
            dx = Input.GetAxis("Horizontal") * PlayerSpeed;
            dy = Input.GetAxis("Vertical") * PlayerSpeed;
        }
        if ((Input.GetAxis("Horizontal") + Input.GetAxis("Vertical")) == 0)
        {
            AnimController.SetInteger("Position", 0);
        }

        //////анимация

        if (Input.GetAxis("Vertical") > 0)
        {
            AnimController.SetInteger("Position", 12);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            AnimController.SetInteger("Position", 6);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            AnimController.SetInteger("Position",3);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            AnimController.SetInteger("Position", 9);
        }

    }
}

