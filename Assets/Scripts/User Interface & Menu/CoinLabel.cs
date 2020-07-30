using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLabel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("gold").ToString();
    }

    public void IncreaseCoins(){
      PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold")+20);
      GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("gold").ToString();
    }
}
