using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pllayermovementscript : MonoBehaviour
{

    public float m_Speed = 10.0f; 
    Rigidbody2D m_Rigidbody;
    public float m_JumpPower = 10.0f;
    public int m_MaxJumps = 2;
    private int m_currentjumps;

    void Start()
    {
        m_currentjumps = m_MaxJumps;
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // update is called once per frame

    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        m_Rigidbody.linearVelocity = new Vector2(xMove * m_Speed, m_Rigidbody.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && m_currentjumps>0)
        {
            m_Rigidbody.AddForce(Vector2.up * m_JumpPower, ForceMode2D.Impulse);
            m_currentjumps--;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
            m_currentjumps = m_MaxJumps;
    }
}
