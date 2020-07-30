using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> Boxes = new List<GameObject>();
    [SerializeField]private GameObject Box;
    [SerializeField]private float size = 1f, offset = 0.2f, startHeight = -0.5f;

    void Start(){
      if(Boxes.Count > 0){
        BoxRearrange();
      }
    }

    public void addBox(){
      GameObject BoxClone = Instantiate(Box, Vector3.zero, Quaternion.identity) as GameObject;
      Boxes.Add(BoxClone);
      BoxRearrange();
    }

    public void BoxRearrange(){
        gameObject.transform.position = new Vector3(transform.position.x, (transform.position.y)+(Boxes.Count)*(size+offset),transform.position.z);
        int i = 1;

        foreach(GameObject reBox in Boxes){
          reBox.transform.position = new Vector3(transform.position.x, transform.position.y+startHeight-(i*(size+offset)),transform.position.z);
          i++;
        }
    }

}
