using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour

{

    public GameObject panelExit;
    // Start is called before the first frame update
    void Start()
    {
        panelExit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelExit.SetActive(true);
        }
    }

    public void DesactivaPanelPregunta()
    {
        if (panelExit.activeSelf == true)
        {
            panelExit.SetActive(false);
        }
    }

    public void QuitGame()
    {
        print("SALI del JUEGO");
        Application.Quit();
    }
}
