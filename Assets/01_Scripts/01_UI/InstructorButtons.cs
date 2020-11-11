using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 
/// Name: Junho Kim
/// Student#: 101136986
/// The Source file name: InstructorButtons.cs
/// Date last Modified: 2020-11-11
/// Program description
///  - Managing buttons: Back to main menu button, next and previous page buttons
///  - Set active / deactive the panels and buttons
///  
/// Revision History
/// 2020-11-11: Added buttons with loading scenes and panels
/// 
/// </summary>


public class InstructorButtons : MonoBehaviour
{
    #region Variables
    [Header("Scene Name")]
    public string BackScene;

    [Header("Panels")]
    public GameObject panel_01;
    public GameObject panel_02;

    [Header("Buttons")]
    public GameObject nextBtn;
    public GameObject previousBtn;

    #endregion

    #region Unity_Method
    private void Start()
    {
        // at start, only set active the panel 01 and next button.
        panel_01.SetActive(true);
        panel_02.SetActive(false);

        nextBtn.SetActive(true);
        previousBtn.SetActive(false);
    }

    #endregion


    #region Custom_Method

    // back to main menu button
    public void OnBack()
    {
        SceneManager.LoadScene(BackScene);
    }

    // set active panel page 01
    public void OnPrevious()
    {
        panel_01.SetActive(true);
        panel_02.SetActive(false);

        nextBtn.SetActive(true);
        previousBtn.SetActive(false);
    }

    // set active panel page 02 

    public void OnNext()
    {
        panel_01.SetActive(false);
        panel_02.SetActive(true);

        nextBtn.SetActive(false);
        previousBtn.SetActive(true);
    }

    #endregion


}
