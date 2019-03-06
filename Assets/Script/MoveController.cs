using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    

    public void Move(float dx, float dy)
    {
        m_Rigidbody2D.velocity = new Vector2(dx, dy);
    }
}
