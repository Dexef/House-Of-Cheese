using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager : MonoBehaviour
{
    // implementa il pattern singleton

    public static game_manager instance;
    public GameObject player;

    private static GameObject playerInstance;

    public game_manager getInstance { get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        //se non c'è un giocatore, ne instanzia uno
        if(playerInstance == null)
        {
            playerInstance = Instantiate(player, gameObject.transform.position, gameObject.transform.rotation);
            //fa si che il player non venga distrutto fra un'istanza e l'altra
            DontDestroyOnLoad(playerInstance);
        }
        else
        {
            playerInstance.SetActive(true);
        }


        //fai si che il game_manager non venga distrutto al cambio di scena
        DontDestroyOnLoad(gameObject);
    }

    //disattiva il player per evitare interferenze con i controlli e la telecamera
    public static void setPlayerInactive()
    {
        playerInstance.SetActive(false);
    }

}
