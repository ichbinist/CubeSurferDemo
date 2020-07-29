using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsOrbit : MonoBehaviour
{
    public GameObject[] Levels;
    private NonRemovablesSatellite nonremovables;
    public void Start(){
      InitiateLevels(0);
      nonremovables = FindObjectOfType<NonRemovablesSatellite>();
      nonremovables.Rearrange();
    }

    public void NextLevel(){
      InitiateLevels(MainOrbit.currentLevel+1);
      MainOrbit.currentLevel++;
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
}
