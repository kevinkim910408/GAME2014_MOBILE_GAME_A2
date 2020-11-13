using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 
/// Name: Junho Kim
/// Student#: 101136986
/// The Source file name: CharacterSelection.cs
/// Date last Modified: 2020-11-13
/// Program description
///  - 
///  
/// Revision History
/// 2020-11-13: 
/// 
/// </summary>
/// 
public class CharacterSelection : MonoBehaviour
{
    #region Variables

    public GameObject[] GO;
    public int index;

    public string StartScene;
    public string BackScene;

    #endregion

    #region Unity_Methods
    private void Start()
    {
        index = 0;
    }

    #endregion

    #region Custom_Methods

    public void OnNext()
    {
        GO[index].SetActive(false);
        index = (index + 1) % GO.Length;
        //index++;
        //if(index > GO.Length)
        //{
        //    index = 0;
        //}
        GO[index].SetActive(true);
    }

    public void OnPrevious()
    {
        GO[index].SetActive(false);
        index--;
        if(index < 0)
        {
            index += GO.Length;
        }
        GO[index].SetActive(true);
    }

    public void OnStart()
    {
        PlayerPrefs.SetInt("playerIndex", index);
        SceneManager.LoadScene(StartScene);
    }

    public void OnBack()
    {
        SceneManager.LoadScene(BackScene);
    }
    #endregion

    #region Trigger_Methods
    #endregion
}
