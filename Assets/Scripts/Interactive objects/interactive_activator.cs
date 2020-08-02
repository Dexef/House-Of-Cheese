using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactive_activator : MonoBehaviour
{
    //utilizzato per gestire l'interazione con il giocatore, l'oggetto dell'interazione deve 
    //contenere un gameobject interactor con il metodo action()

    public GameObject interactor;
    private snes_interaction interactorScript;

    private void Start()
    {
        interactor.SetActive(false);
        interactorScript = interactor.GetComponent<snes_interaction>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //attiva l'interactor
        interactor.SetActive(true);

        //passa collider all'interactor
        interactorScript.action(other, true);
    }

    private void OnTriggerExit(Collider other)
    {
        //disattiva l'interactor
        interactor.SetActive(false);

        //passa collider all'interactor
        interactorScript.action(other, false);

    }
}
