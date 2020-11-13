using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 
/// Name: Junho Kim
/// Student#: 101136986
/// The Source file name: AfterDieButtons.cs
/// Date last Modified: 2020-11-13
/// Program description
///  - After player dead, there will be 2 options with 2 buttons. - retry and back to main menu
///  - This script is managing the buttons only
///  
/// Revision History
/// 2020-11-13: Added buttons
/// 
/// </summary>
/// 
public class AfterDieButtons : MonoBehaviour
{
    #region Variables
    public string retryScene;
    public string MenuScene;

    #endregion

    #region Custom_Methods

    public void OnRetry()
    {
        SceneManager.LoadScene(retryScene);
    }

    public void OnMenu()
    {
        SceneManager.LoadScene(MenuScene);
    }


    #endregion
}
