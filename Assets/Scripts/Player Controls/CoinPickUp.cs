using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
      {
          //Check to see if the tag on the collider is equal to Enemy
          if (other.tag == "Coin")
          {
              PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold")+20);
              Destroy(other);
          }
      }
}
