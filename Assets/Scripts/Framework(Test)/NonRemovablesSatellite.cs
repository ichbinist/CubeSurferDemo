using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonRemovablesSatellite : MonoBehaviour
{
    public GameObject[] FixedObjects;
    [SerializeField] private GameObject[] AllObjects;
    GameObject separator;
    public void Rearrange(){
      AllObjects = GameObject.FindObjectsOfType<GameObject>();
      if(separator == null){
        separator = new GameObject();
        separator.name = "----------------";
      }
      separator.transform.SetSiblingIndex(AllObjects.Length);

      foreach(GameObject sceneobjects in FixedObjects){
        sceneobjects.transform.SetSiblingIndex(AllObjects.Length);
      }

    }
}
