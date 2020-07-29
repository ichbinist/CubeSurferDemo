using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySatellite : MonoBehaviour
{

  void Start(){
    if(PlayerPrefs.HasKey("gold")){
      //Do Nothing
    }else{
      PlayerPrefs.SetInt("gold", 0);
    }
  }
}
