using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLabel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        showGold();
    }
    public void showGold(){
      GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("gold").ToString();
    }
}
