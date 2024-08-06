using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ZehirSeviyesi : MonoBehaviour
{
    private void Update()
    {
        switch (ToplamVeriler.Can)
        {
            case 3:
                break;
            case 2:
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 1:
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
                break;
            case 0:
                SceneManager.LoadScene(2);
                break;
            default:
                break;
            
        }
    }
}
