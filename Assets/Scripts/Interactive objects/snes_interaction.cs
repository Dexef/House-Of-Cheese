using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class snes_interaction : MonoBehaviour
{
    Collider _collider;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _collider != null)
        {
            //disattiva il giocatore e carica scena del gioco
            //game_manager.savePlayer();
            game_manager.setPlayerInactive();
            SceneManager.LoadScene("shoot-em-up");
        }
    }

    public void action(Collider col, bool enable)
    {
        _collider = col;
        Text _text = _collider.gameObject.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>();

        if (enable == true)
        {
            _text.text = "Premi E per giocare";
        }
        else
        {
            _text.text = "";
            _collider = null;
        }
    }
}
