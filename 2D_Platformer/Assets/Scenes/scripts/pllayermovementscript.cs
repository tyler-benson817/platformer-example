using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pllayermovementscript : MonoBehaviour
{

    public float m_Speed = 10.0f; 
    Rigidbody2D m_Rigidbody;
    public float m_JumpPower = 10.0f;
    // start is called before the first frame update

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // update is called once per frame

    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        m_Rigidbody.linearVelocity = new Vector2(xMove * m_Speed, m_Rigidbody.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(Vector2.up * m_JumpPower, ForceMode2D.Impulse);
        }
    }
}
