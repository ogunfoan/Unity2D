using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Can : MonoBehaviour
{
    private void Awake()
    {
        switch (ToplamVeriler.Can)
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
