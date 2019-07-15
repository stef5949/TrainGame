using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowScript : MonoBehaviour
{
    public int maxSound;

    private bool playerHere = false;
    private int currentSound;

    // Start is called before the first frame update
    void Start()
    {
        currentSound = 0;

    }


    private void OnTriggerEnter(Collider other)
    {
        playerHere = true;
        if(maxSound == currentSound)
        { PlayerDeath(); }
    }

    private void OnTriggerExit(Collider other)
    {
        playerHere = false;
    }

    public void MonsterTrigger()
    {
        if (playerHere)
        {
            PlayerDeath();
        }

    }

    public void IncreaseCurrentSound(int soundIncrease) {
        
        currentSound += soundIncrease;
        if (currentSound > maxSound)
        {
            currentSound = maxSound;
        }

    }

    public int GetCurrentSound() {

        return currentSound;
    }

    

    private void PlayerDeath()
    {
      // player death code goes here

    }

}



