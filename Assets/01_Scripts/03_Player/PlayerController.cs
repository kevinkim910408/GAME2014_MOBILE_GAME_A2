using UnityEngine;

/// <summary>
/// 
/// Name: Junho Kim
/// Student#: 101136986
/// The Source file name: PlayerController.cs
/// Date last Modified: 2020-11-13
/// Program description
///  - to control the player's movement, jump, animations etc
///  
/// Revision History
/// 2020-11-13: added rigid body and made movement, animation of fliping
/// 
/// </summary>
/// 
public class PlayerController : MonoBehaviour
{
    #region Variables

    // control player max speed 
    public float maxSpeed;


    // components
    Animator animator;
    Rigidbody2D rigid2D;

    [SerializeField]
    GameObject playerPrefab = null;



    #endregion

    #region Unity_Methods
    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // get ket up - stop speed
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid2D.velocity = new Vector2(rigid2D.velocity.normalized.x * 0.5f, rigid2D.velocity.y);
        }

        // to flip player image
        if (Input.GetButtonDown("Horizontal"))
        {

            // rotate player's Y-Axis
            Quaternion rotation = Quaternion.identity; // set zero

            // left
            if (Input.GetAxisRaw("Horizontal") == -1)
            {
                rotation.eulerAngles = new Vector3(0, 180, 0);
                playerPrefab.transform.rotation = rotation;
            }
            // right
            else if (Input.GetAxisRaw("Horizontal") == 1)
            {
                rotation.eulerAngles = new Vector3(0, 0, 0);
                playerPrefab.transform.rotation = rotation;
            }
        }

        // walking animation
        if(Mathf.Abs(rigid2D.velocity.x) < 0.3f)
        {
            animator.SetBool("isWalk", false);
        }
        else
        {
            animator.SetBool("isWalk", true);
        }
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        // get key input
        float moveX = Input.GetAxisRaw("Horizontal");

        // add force
        rigid2D.AddForce(Vector2.right * moveX, ForceMode2D.Impulse);

        // Max speed - right
        if (rigid2D.velocity.x > maxSpeed)
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
