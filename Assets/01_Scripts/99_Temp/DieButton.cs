using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// Name: Junho Kim
/// Student#: 101136986
/// The Source file name: DieButton.cs
/// Date last Modified: 2020-11-13
/// Program description
///  - This is temp die button - will be removed or deactivated
///  
/// Revision History
/// 2020-11-13: only set active or deactive the panel
/// 
/// </summary>
/// 
public class DieButton : MonoBehaviour
{
    public GameObject diePanel;

    void Start()
    {
        diePanel.SetActive(false);
    }
   public void OnDie()
    {
        diePanel.SetActive(true);
    }
}
