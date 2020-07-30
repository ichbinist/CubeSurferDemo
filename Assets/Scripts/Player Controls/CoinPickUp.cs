using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
  private CoinLabel c_Label;
  void Start(){
    c_Label = FindObjectOfType<CoinLabel>();
  }
  private void OnTriggerEnter(Collider other)
      {
          //Check to see if the tag on the collider is equal to Enemy
          if (other.tag == "Coin")
          {
              PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold")+20);
              c_Label.showGold();
              Destroy(other);
          }
      }
}
