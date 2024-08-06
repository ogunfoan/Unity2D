using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ZehirSeviyesi : MonoBehaviour
{
    private SceneManager _sceneManager;
    private void Awake()
    {
        switch (ToplamVeriler.Eksican)
        {
            case 3:
                break;
            case 2:
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                break;
            case 1:
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
                break;
            case 0:
                SceneManager.LoadScene(2);
                break;
            default:
                break;
            
        }
    }
}
