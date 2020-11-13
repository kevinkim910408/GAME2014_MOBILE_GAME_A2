using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// Name: Junho Kim
/// Student#: 101136986
/// The Source file name: LoadPlayer.cs
/// Date last Modified: 2020-11-13
/// Program description
///  - Load Player using "PlayerPrefs" from player selection.
///  
/// Revision History
/// 2020-11-13: 
/// 
/// </summary>
/// 
public class LoadPlayer : MonoBehaviour
{
    #region Variables
    // to be used at Instantiate.
    public GameObject[] playerPrefabs;

    // the location of spawning player
    public Transform spawnPlayerPoint;

    #endregion

    #region Unity_Methods

    private void Start()
    {
        // load selected player's info
        int index = PlayerPrefs.GetInt("playerIndex");

        // spawn player
        GameObject go = 
            Instantiate(playerPrefabs[index], spawnPlayerPoint.position, Quaternion.identity);
    }
    #endregion

    #region Custom_Methods




    #endregion

    #region Trigger_Methods
    #endregion
}
