using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieButton : MonoBehaviour
{
    public GameObject diePanel;

    // Start is called before the first frame update
    void Start()
    {
        diePanel.SetActive(false);
    }

   public void OnDie()
    {
        diePanel.SetActive(true);
    }
}
