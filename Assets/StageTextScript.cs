using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StageTextScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int gameLevel = LevelStaticDataScript.level;
        GetComponent<TextMeshProUGUI>().text = "Stage " + gameLevel.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
