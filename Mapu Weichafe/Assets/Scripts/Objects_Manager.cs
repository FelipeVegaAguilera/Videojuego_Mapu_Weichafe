using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objects_Manager : MonoBehaviour
{

    //public Text levelCleared;
    public GameObject transition;


    private void Update()
    {
        AllCollected();
    }


    public void AllCollected()
    {
        if (transform.childCount == 0)
        {
            //levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
}
