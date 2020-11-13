using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 
/// Name: Junho Kim
/// Student#: 101136986
/// The Source file name: TitleFunc.cs
/// Date last Modified: 2020-11-13
/// Program description
///  - Load Scenes with buttons from Title Scene
///  
/// Revision History
/// 2020-11-11: Added Start and Instructor buttons with loading scenes
/// 2020-11-13: Change the class name "TitleButtons" -> "TitleFunc"
/// 
/// </summary>

public class TitleFunc : MonoBehaviour
{
    #region Variables

    [Header("Scene Names")]
    public string StartScene;
    public string InstructorScene;

    #endregion

    #region Custom_Method

    // Move the scene with start button
    public void OnStart()
    {
        SceneManager.LoadScene(StartScene);
    }

    // Move the scene with "i" button
    public void OnInstructor()
    {
        SceneManager.LoadScene(InstructorScene);
    }
    #endregion
}