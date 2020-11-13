using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// Name: Junho Kim
/// Student#: 101136986
/// The Source file name: BackgroundScrolling.cs
/// Date last Modified: 2020-11-13
/// Program description
///  - Background scrolling horizontally
///  
/// Revision History
/// 2020-11-13: Added functions of moving horizontally
/// 
/// </summary>
/// 
public class BackgroundScrolling : MonoBehaviour
{
    #region Variables
    //public float verticalSpeed;         // y - axis
    //public float verticalBoundary;

    [Header("Scrolling Speed")]
    public float horizontalSpeed;          // x - axis

    [Header("Boundary Check")]
    public float horizontalBoundary;

    #endregion

    #region Unity_Method
    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    #endregion

    #region Custom_Method

    // to reset background position
    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    // background move horizontally. ( right side to left side)
    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    // to check bounds. If backgrounds hit this bounds, reset their position.
    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -30.0f)
        {
            _Reset();
        }
    }
    #endregion
}
