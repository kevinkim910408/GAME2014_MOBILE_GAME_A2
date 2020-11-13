using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// Name: Junho Kim
/// Student#: 101136986
/// The Source file name: AfterDieButtons.cs
/// Date last Modified: 2020-11-13
/// Program description
///  - 
///  
/// Revision History
/// 2020-11-13: 
/// 
/// </summary>
/// 
public class LoadPlayer : MonoBehaviour
{
    #region Variables
    public GameObject[] playerPrefabs;
    public Transform spawnPlayerPoint;

    #endregion

    #region Unity_Methods

    private void Start()
    {
        int index = PlayerPrefs.GetInt("playerIndex");
        GameObject go = 
            Instantiate(playerPrefabs[index], spawnPlayerPoint.position, Quaternion.identity);
    }
    #endregion

    #region Custom_Methods




    #endregion

    #region Trigger_Methods
    #endregion
}
