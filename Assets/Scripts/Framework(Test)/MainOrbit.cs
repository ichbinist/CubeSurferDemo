using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainOrbit : MonoBehaviour
{
    [HideInInspector]public static int currentLevel;
    private LevelsOrbit levelorbit;
    void Start(){
      levelorbit = FindObjectOfType<LevelsOrbit>();
    }

    void Update(){
      if (Input.GetKeyDown("space"))
        {
            levelorbit.NextLevel();
        }
    }
}
