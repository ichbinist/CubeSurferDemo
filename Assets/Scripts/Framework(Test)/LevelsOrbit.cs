using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsOrbit : MonoBehaviour
{
    public GameObject[] Levels;
    private NonRemovablesSatellite nonremovables;
    public void Start(){

      if(PlayerPrefs.HasKey("currLevel")){
        InitiateLevels(PlayerPrefs.GetInt("currLevel"));
      }else{
        PlayerPrefs.SetInt("currLevel", 0);
        InitiateLevels(PlayerPrefs.GetInt("currLevel"));
      }

      nonremovables = FindObjectOfType<NonRemovablesSatellite>();
      nonremovables.Rearrange();
    }

    public void NextLevel(){
      InitiateLevels(PlayerPrefs.GetInt("currLevel")+1);
      PlayerPrefs.SetInt("currLevel",PlayerPrefs.GetInt("currLevel")+1);
      nonremovables.Rearrange();
    }

    public void InitiateLevels(int currentLevel){
      GameObject[] LevelsInScene = GameObject.FindGameObjectsWithTag("Level");
      if(LevelsInScene.Length > 0){
        foreach(GameObject level in LevelsInScene){
          Destroy(level);
        }
      }

      Instantiate(Levels[currentLevel],Vector3.zero,Quaternion.identity);

    }

    public void RestartLevel(){
        InitiateLevels(PlayerPrefs.GetInt("currLevel"));
    }
}
