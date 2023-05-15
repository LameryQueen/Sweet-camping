using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    // Start is called before the first frame updat
    public GameObject loadingScreen;
    public int sceneNew;
    public void LoadLvl(int numScene)
    {
        loadingScreen.SetActive(true);
        sceneNew = numScene;

        Invoke("Retardo", 3f);
     //   operation.
    }

    public void Retardo()
    {
        StartCoroutine(LoadAsynchrnolously(sceneNew));
    }

    IEnumerator LoadAsynchrnolously(int scene)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(scene);
      //  loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            print("Se esta cargando");
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);

            yield return null;
        }

     //   loadingScreen.SetActive(false);

    }
 }
