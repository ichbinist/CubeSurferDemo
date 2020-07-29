using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSatellite : MonoBehaviour
{
    public Color BackgroundColor;
    private Camera maincam;

    void Start(){
      maincam = FindObjectOfType<Camera>();
      maincam.backgroundColor = BackgroundColor;
    }
}
