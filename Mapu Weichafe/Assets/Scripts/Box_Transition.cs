using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Transition : MonoBehaviour
{

    public GameObject transition;

    private void Update()
    {
       BoxCollected();
    }


    public void BoxCollected()
    {
        if (transform.childCount == 0)
        {
            transition.SetActive(true);
        }
    }

    
}
