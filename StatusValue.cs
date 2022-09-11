using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatusValue : MonoBehaviour
{

    public GameController gameController;
    TextMeshProUGUI mytext;
    
    void Awake() {
        mytext=GetComponent<TextMeshProUGUI>();
    }
    void OnEnable(){
        name=gameObject.name;
        string localname=name;
        int localstat=gameController.statusdictionary[localname];
        Debug.Log(localstat);
    }
}
