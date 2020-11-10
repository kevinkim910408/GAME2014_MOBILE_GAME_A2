using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour
{
    public string StartScene;
    public string InstructorScene;

    public void OnStart()
    {
        SceneManager.LoadScene(StartScene);
    }

    public void OnInstructor()
    {
        SceneManager.LoadScene(InstructorScene);
    }
}
