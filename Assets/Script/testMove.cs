using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMove : MonoBehaviour
{
    public Rigidbody2D PLayerForce;
    public float dx, dy;
    public float PlayerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
       
            dirvelocity();
            if (Input.GetKey(KeyCode.W))
            {
                //sbrosAnim();
                //HeroAmim.SetBool ("Up",true);
                PLayerForce.velocity = new Vector2(dx, dy);
            }

            if (Input.GetKey(KeyCode.S))
            {
                //sbrosAnim();
                //HeroAmim.SetBool ("Down",true);	
                PLayerForce.velocity = new Vector2(dx, dy);
            }

            if (Input.GetKey(KeyCode.A))
            {
                //sbrosAnim();
                //HeroAmim.SetBool ("Left",true);	
                PLayerForce.velocity = new Vector2(dx, dy);
            }
            if (Input.GetKey(KeyCode.D))
            {
                //sbrosAnim();
                //HeroAmim.SetBool ("Right",true);
                PLayerForce.velocity = new Vector2(dx, dy);
            }
            if (Input.anyKey == false)
            {
                //sbrosAnim();
                PLayerForce.velocity = new Vector2(0, 0);
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
    }
}
