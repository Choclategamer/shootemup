using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIscript : MonoBehaviour
{

    public float money;
    public float wave; // de naam wave

    public Text moneyText;
    public Text waveCount; // welke wave je bent

    // Start is called before the first frame update
    void Start()
    {  
       
    }

    // Update is called once per frame
    void Update()
    {
       
        waveCount.text = wave.ToString();       
    }



  
}
    