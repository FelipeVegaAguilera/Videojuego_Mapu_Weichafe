using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBasic : MonoBehaviour
{
    
    public Animator anim;
    public SpriteRenderer sprtR;
    public float speed = 2f;

    private float waiteTime;
    public float startWaitTime; 

    public Transform[] moveSpots;

    private int i = 0;
    private Vector2 actualPos;

    void Start()
    {
        waiteTime = startWaitTime;
    }

    
    void Update()
    {
        
        StartCoroutine(CheckEnemyMoving());

        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position,moveSpots[i].transform.position)<0.2f)
        {
            if(waiteTime<=0)
            {
                if(moveSpots[i] != moveSpots[moveSpots.Length-1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }

                waiteTime = startWaitTime;

            }
            else
            {
                waiteTime -= Time.deltaTime;
            }
        }
    }


    IEnumerator CheckEnemyMoving()
    {

        actualPos = transform.position;

        yield return new WaitForSeconds(0.5f);

        if (transform.position.x > actualPos.x)
        {
            sprtR.flipX = true;
        }
        else if (transform.position.x < actualPos.x)
        {
            sprtR.flipX = false;
        }

    }

}
