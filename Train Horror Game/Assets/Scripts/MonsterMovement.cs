using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{

    GameObject targetWindow;

    windowScript[] windows = new windowScript[4];

    float speed;



    // Start is called before the first frame update
    void Start()
    {
        
    }


    

    // Update is called once per frame
    void Update()
    {
        targetWindow = GetTargetWindow(windows);

        
    }

    GameObject GetTargetWindow(windowScript[] windows)
    {
        GameObject target = null;

        int loudestWindow = 0;

        foreach (windowScript win in  windows)
        {
            if(win.GetCurrentSound() > loudestWindow)
            {
                loudestWindow = win.GetCurrentSound();
                target = win.gameObject;
            }
            else if( win.GetCurrentSound() == loudestWindow && target != null) // in case two windows are equally loud
            {
                Vector3 targetPos = target.transform.position;
                Vector3 newPos = win.gameObject.transform.position;

                float currentTargetDistance = Vector3.Distance(targetPos, transform.position);
                float newTargetDistance = Vector3.Distance(newPos, transform.position);

                if ( currentTargetDistance > newTargetDistance ) // if the new window is closer to the monster, set new window as target
                {
                    target = win.gameObject;
                }

            }
        }

        if (target == null) // in case there is no target set, the monster itself is the target (monster wont move)
        {
            target = gameObject;
        }


        return target;

    }


    private void MoveTowardsWindow (GameObject target)
    {
        
    }

    private void MoveMonsterToRandomWindow(windowScript[] windows)
    {
        
    }

    void AppearInWindow()
    {

    }

    void Attack()
    {

    }

}
