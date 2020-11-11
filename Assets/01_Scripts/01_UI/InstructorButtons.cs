using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructorButtons : MonoBehaviour
{
    public string BackScene;

    public GameObject panel_01;
    public GameObject panel_02;

    public GameObject nextBtn;
    public GameObject previousBtn;

    private void Start()
    {
        panel_01.SetActive(true);
        panel_02.SetActive(false);

        nextBtn.SetActive(true);
        previousBtn.SetActive(false);
    }


    public void OnBack()
    {
        SceneManager.LoadScene(BackScene);
    }

    public void OnPrevious()
    {
        panel_01.SetActive(true);
        panel_02.SetActive(false);

        nextBtn.SetActive(true);
        previousBtn.SetActive(false);
    }

    public void OnNext()
    {
        panel_01.SetActive(false);
        panel_02.SetActive(true);

        nextBtn.SetActive(false);
        previousBtn.SetActive(true);
    }

  
}
