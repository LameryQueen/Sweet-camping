using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.Video;
using UnityEngine;

public class MenuController : MonoBehaviour

{
    //PANTALLAS DEL MENU
    public GameObject panelIni;
    public GameObject panelMenu;
    public GameObject panelOptions;
    //BOTONES
    public GameObject startBo;
    public GameObject optionBo;
    public GameObject quitBo;
    public GameObject loadBo;
    //ANIMACIONES DE ENTRADA Y SALIDA
    public GameObject panelIn;
    public GameObject panelOut;
    public Animator anim;
    public bool entrada = false;
    public bool salida = false;
    //AUDIO
    public AudioMixer master;

    void Start()
    {
        panelIni.SetActive(true);
        panelOptions.SetActive(false);

        panelOut.SetActive(false);
        panelIn.SetActive(true);
    }

    void Update()
    {
        if (entrada == false)
        {
            if (Input.anyKeyDown)
            {
                EntradaMenu();
            }
        }
    }
    //ACTIVA EL MENU PRICNIPAL
    public void EntradaMenu()
    {
        entrada = true;
        anim.SetBool("Entrada", true);
    }
    //INICIA EL JUEGO
    public void StartGame()
    {
        panelOut.SetActive(true);
        panelIn.SetActive(false);
        salida = true;
        anim.SetBool("Salida", true);
        entrada = false;
        anim.SetBool("Entrada", false);
        //HACE QUE TARDE EN LLAMAR LA FUNCION
        Invoke("CambioEscena", 1f);
    }
    //CAMBIA E INICIA LA PARTIDA
    public void CambioEscena()
    {
        SceneManager.LoadScene(1);
    }
    //ACTIVA EL MENU DE OPCIONES
    public void OpcionesActivadas()
    {
        panelOptions.SetActive(true);
        startBo.SetActive(false);
        loadBo.SetActive(false);
        quitBo.SetActive(false);
    }

    //SE USA PARA VOLVER AL MENU PRINCIPAL 
    public void BackButtom()
    {
        if (panelOptions == false)
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
        Application.Quit();
    }

}
