using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text difficulty = GetComponent<Text>();
        difficulty.text = (PlayerPrefsManager.GetDifficulty()).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
