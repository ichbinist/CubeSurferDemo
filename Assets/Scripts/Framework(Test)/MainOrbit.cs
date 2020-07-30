using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainOrbit : MonoBehaviour
{
    private LevelsOrbit levelorbit;
    private MenuControl menucontrol;
    void Start(){
      levelorbit = FindObjectOfType<LevelsOrbit>();
      menucontrol = FindObjectOfType<MenuControl>();
    }

    void Update(){
      if (Input.GetKeyDown("space")){ //Bölüm geçme kısayolu, sadece debugging için
            menucontrol.PassPanelControl();
            PlayerPrefs.Save();
        }
        if (Input.GetKeyDown("x")){ //Bölüm kaybetme kısayolu, sadece debugging için
              menucontrol.FailPanelControl();
          }
    }
}
