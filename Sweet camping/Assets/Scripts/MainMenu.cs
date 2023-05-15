using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.Video;
using UnityEngine;

public class MainMenu : MonoBehaviour

{
    //PANTALLAS DEL MENU
    public GameObject panelIni;
    public GameObject panelMenu;
    public GameObject panelOptions;
    public GameObject panelExit;
    public GameObject panelEnterGame;
    //BOTONES
    public GameObject startBo;
    public GameObject optionBo;
    public GameObject quitBo;
    public GameObject loadBo;
    //ANIMACIONES DE ENTRADA Y SALIDA
    public GameObject panelIn;
    public GameObject panelOut;
   // public Animator anim;
    public bool entrada = false;
    public bool salida = false;
    //AUDIO
    public AudioMixer master;
    //LOAD SCENE
    private LoadingScreen lvl;
    public int numScene;

    void Start()
    {
        panelIni.SetActive(true);
        panelOptions.SetActive(false);
        panelMenu.SetActive(false);
        panelExit.SetActive(false);
        panelEnterGame.SetActive(false);

        panelOut.SetActive(false);

        lvl = GameObject.FindAnyObjectByType<LoadingScreen>();
        // panelIn.SetActive(true);
    }

    void Update()
    {        
            if (Input.anyKeyDown)
            {
                EntradaMenu();
            }
            //PANEL SI QUIERES SALIR DEL JUEGO
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                 panelExit.SetActive(true);
            }
            //PANEL QUE PREGUNTA SI QUIERES ENTRAR AL JUEGO
            if (Input.GetButtonDown("Submit"))
            {
                 panelEnterGame.SetActive(true);
            }
        
    }

    public void DesactivaPanelPregunta()
    {
        if (panelEnterGame.activeSelf == true)
        {
            panelEnterGame.SetActive(false);
        }
        if (panelExit.activeSelf == true)
        {
            panelExit.SetActive(false);
        }   
    }
    //ACTIVA EL MENU PRICNIPAL
    public void EntradaMenu()
    {
        entrada = true;
        panelMenu.SetActive(true);
        panelIni.SetActive(false);
      //  anim.SetBool("Entrada", true);
    }
    //INICIA EL JUEGO
    public void StartGame()
    {
        
        panelOut.SetActive(true);
        panelIn.SetActive(false);
        salida = true;
      //  anim.SetBool("Salida", true);
        entrada = false;
      //  anim.SetBool("Entrada", false);
        //HACE QUE TARDE EN LLAMAR LA FUNCION
        Invoke("CambioEscena", 1f);
    }
    //CAMBIA E INICIA LA PARTIDA
    public void CambioEscena()
    {
        lvl.LoadLvl(numScene);
      //  SceneManager.LoadScene(1);
    }
    //ACTIVA EL MENU DE OPCIONES
    public void OpcionesActivadas()
    {
        panelOptions.SetActive(true);
        startBo.SetActive(false);
        loadBo.SetActive(false);
        quitBo.SetActive(false);
        optionBo.SetActive(false);
    }

    //SE USA PARA VOLVER AL MENU PRINCIPAL 
    public void BackButtom()
    {
        if (panelOptions == true)
        {
            panelOptions.SetActive(false);

            startBo.SetActive(true);
            loadBo.SetActive(true);
            quitBo.SetActive(true);
            optionBo.SetActive(true);

        }
    }
    //MODIFICA EL VOLUMEN
    public void SetVolumen(float vol)
    {
        master.SetFloat("vol", vol);
    }
    //TE SALES DEL JUEGO
    public void QuitGame()
    {
        print("SALI del JUEGO");
        Application.Quit();
    }

}
