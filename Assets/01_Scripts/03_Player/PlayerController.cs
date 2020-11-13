using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// Name: Junho Kim
/// Student#: 101136986
/// The Source file name: PlayerController.cs
/// Date last Modified: 2020-11-13
/// Program description
///  - 
///  
/// Revision History
/// 2020-11-13: 
/// 
/// </summary>
/// 
public class PlayerController : MonoBehaviour
{
    #region Variables

    private Rigidbody2D rigid2D;
    public float maxSpeed;


    #endregion

    #region Unity_Methods
    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // get ket up - stop speed
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid2D.velocity = new Vector2(rigid2D.velocity.normalized.x * 0.5f, rigid2D.velocity.y);
        }
    }

    private void FixedUpdate()
    {
        // get key input
        float moveX = Input.GetAxisRaw("Horizontal");
        // add force
        rigid2D.AddForce(Vector2.right * moveX, ForceMode2D.Impulse);

        // Max speed - right
        if(rigid2D.velocity.x > maxSpeed)
        {
            rigid2D.velocity = new Vector2(maxSpeed, rigid2D.velocity.y);
        }
        // Max speed - left
        else if (rigid2D.velocity.x < (-1) * maxSpeed)
        {
            rigid2D.velocity = new Vector2((-1) * maxSpeed, rigid2D.velocity.y);
        }

    }


    #endregion

    #region Custom_Methods




    #endregion

    #region Trigger_Methods
    #endregion
}
