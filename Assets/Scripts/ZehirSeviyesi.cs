using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ZehirSeviyesi : MonoBehaviour
{
    private void Awake()
    {
        switch (ToplamVeriler.Eksican)
        {
            case 3:
                break;
            case 2:
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                break;
            case 1:
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
                break;
            case 0:
                SceneManager.LoadScene(4);
                break;
            
            default:
                break;
            
        }
    }
}
