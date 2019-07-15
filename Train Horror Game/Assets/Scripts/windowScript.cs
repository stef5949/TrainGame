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
        { playerDeath(); }
    }

    private void OnTriggerExit(Collider other)
    {
        playerHere = false;
    }

    public void monsterTrigger()
    {
        if (playerHere)
        {
            playerDeath();
        }

    }

    public void setSound(int soundIncrease) {
        int x;
        x = soundIncrease;
        currentSound += x;
    }

    public int getSound() {

        return currentSound;
    }
    private void playerDeath()
    {
      // player death code goes here

    }

}



