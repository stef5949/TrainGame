using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManageFunc : MonoBehaviour
{
    [HideInInspector]
    public static gameManageFunc singleton;

    public windowScript[] Windows = new windowScript[4];


    void Awake() // for setting the singleton
    {
        if( singleton == null)
        {
            singleton = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void LateUpdate()
    {
        soundBehaviour();
    }


    void soundBehaviour()
    {
        int soundcheck = 0;
        int wID = 0;
        for (int i = 0; i < Windows.Length; i++)
        {
            int newSound = Windows[i].GetComponent<windowScript>().getSound();
            if (newSound > soundcheck)
            {
                soundcheck = newSound;
                wID = i;
            }
        }
        Windows[wID].GetComponent<windowScript>().monsterTrigger();
        
    }
}
