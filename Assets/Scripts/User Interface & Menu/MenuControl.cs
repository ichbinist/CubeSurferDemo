using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    [SerializeField] private GameObject StartPanel;
    [SerializeField] private GameObject BottomPanel;
    [SerializeField] private GameObject TopPanel;
    [SerializeField] private GameObject LevelFailedPanel;
    [SerializeField] private GameObject LevelPassedPanel;
    private LevelsOrbit levelorbit;

    void Start(){
        Time.timeScale = 0;
        levelorbit = FindObjectOfType<LevelsOrbit>();
        StartPanel.SetActive(true);
        BottomPanel.SetActive(false);
        TopPanel.SetActive(false);
        LevelFailedPanel.SetActive(false);
        LevelPassedPanel.SetActive(false);
    }

    public void StartGame(){
        Time.timeScale = 1;
        StartPanel.SetActive(false);
        BottomPanel.SetActive(true);
        TopPanel.SetActive(true);
    }

    public void FailPanelControl(){
      Time.timeScale = 0;
      LevelFailedPanel.SetActive(true);
      BottomPanel.SetActive(false);
      TopPanel.SetActive(false);
    }

    public void FailPanelButtonPress(){
      LevelFailedPanel.SetActive(false);
      levelorbit.RestartLevel();
      StartPanel.SetActive(true);
    }

    public void PassPanelControl(){
      Time.timeScale = 0;
      LevelPassedPanel.SetActive(true);
      BottomPanel.SetActive(false);
      TopPanel.SetActive(false);
    }

    public void PassPanelButtonPress(){
      LevelPassedPanel.SetActive(false);
      levelorbit.NextLevel();
      StartPanel.SetActive(true);
    }
}
