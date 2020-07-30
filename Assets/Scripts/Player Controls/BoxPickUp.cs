using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPickUp : MonoBehaviour
{
  private Player player;
  void Start(){
    player = FindObjectOfType<Player>();
  }
  private void OnTriggerEnter(Collider other)
      {
          //Check to see if the tag on the collider is equal to Enemy
          if (other.tag == "BoxPickupable")
          {
              player.addBox();
              Destroy(other);
          }
      }
}
