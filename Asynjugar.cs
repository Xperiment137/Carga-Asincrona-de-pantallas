using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Asynjugar : MonoBehaviour
{

    public string Escena;
    public Button boton1;

    void Start()
    {
        boton1.onClick.AddListener(()=>LoadButton());

    }

    void LoadButton()
    {
       
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        yield return null;

       
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(Escena);
     
         

            yield return null;
        }
    }

