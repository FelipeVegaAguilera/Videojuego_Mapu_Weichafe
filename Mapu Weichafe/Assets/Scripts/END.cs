using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END : MonoBehaviour
{
    private void Update()
    {
        EndCollected();
    }

    public void EndCollected()
    {

        if (transform.childCount==0)
        {
            Debug.Log("No quedan emblemas, Victoria");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
