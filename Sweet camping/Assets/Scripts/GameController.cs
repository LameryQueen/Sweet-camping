using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public Joystick joyStick;
    public Scene localScene; 
    //para cargar el escenario
  //  private LoadingScreen lvl;
    public int numScene;
    public int primeraVez;
    private void Awake()
    {
        //AQUI INICIALIZO TODAS LAS VARIABLES
      //  lvl = GameObject.FindAnyObjectByType<LoadingScreen>();
        localScene = SceneManager.GetActiveScene();
        primeraVez = 0;
    }

    private void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
    
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
           // touchPosition.z = 0f;
            transform.position = touchPosition;
        }

      //  Invoke("Retarde", 1f);

    }

    public void Retarde()
    {

      //  ChangeScene(numScene);

    }

  //  public void ChangeScene (int scene)
  //  {
      //  print("Esta entrando para cargar");
      //  lvl.LoadLvl(scene);
  //  }
}
