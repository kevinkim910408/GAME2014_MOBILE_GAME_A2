using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructorButtons : MonoBehaviour
{
    public string BackScene;
    

    public void OnBack()
    {
        SceneManager.LoadScene(BackScene);
    }

  
}
