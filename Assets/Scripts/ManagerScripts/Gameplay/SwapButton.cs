using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapButton : MonoBehaviour
{
    public GameObject explosion;
    public GameObject player;
    private float timestamp = 0;

    // Start is called before the first frame update
    public void CharSwap()
    {
        //checks time
        if (Time.time >= timestamp && PlayerManager.dead == false)
        {
            Swap();          
        }
        void Swap()
        {
            //finds and removes player char
            
            Destroy(GameObject.FindWithTag("Player"));
            Destroy(GameObject.Find("Tri Player(Clone)"));
            Destroy(GameObject.Find("Circle Player(Clone)"));
            Destroy(GameObject.Find("Hex Player(Clone)"));
            Destroy(GameObject.Find("Square Player(Clone)"));
            //calls new player char to spawn
            Instantiate(player, PlayerManager.playerPos, Quaternion.identity);
        }

    }
    public void Effect()
    {
        //checks time
        if (Time.time >= timestamp)
        {
            // Destroy (GameObject.FindWithTag ("SWAP"));
            Instantiate(explosion, PlayerManager.playerPos, Quaternion.identity);
        }
    }
}

  
 
