using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{   
    [SerializeField] private GameObject levelCompleteCanvas;
    [SerializeField] private GameObject messegeUI;
    private bool _isActivited = false;
    public void Activate(){
        _isActivited = true;
        messegeUI.SetActive(false);
    }
    public void FinishLevel() {
        if(_isActivited) {
            levelCompleteCanvas.SetActive(true);
            gameObject.SetActive(false);
            Time.timeScale = 0f;
        }
        else {
            messegeUI.SetActive(true);
        }
        
    }
}
