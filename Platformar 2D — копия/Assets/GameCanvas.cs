using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] public GameObject pauseCanvas;
  public void PauseHendler(){
      pauseCanvas.SetActive(true);
      Time.timeScale = 0f;

  }
}
