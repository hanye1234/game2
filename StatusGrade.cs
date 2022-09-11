using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatusGrade : MonoBehaviour
{
    TextMeshProUGUI mytext;
    public GameController gameController;
    string localname;
    
    void Awake() {
        mytext=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void OnEnable()
    {
        name=gameObject.name;
        localname=name.Replace("grade","");
        int localstat=gameController.statusdictionary[localname];
        if(localstat>=90){
            mytext.text="S";
        }
        else if(localstat>=80)
            mytext.text="A";
        else if(localstat>=70)
            mytext.text="A-";
        else if(localstat>=60)
            mytext.text="B";
        else if(localstat>=50)
            mytext.text="B-";
        else if(localstat>=40)
            mytext.text="C";
        else if(localstat>=30)
            mytext.text="C-";
        else if(localstat>=20)
            mytext.text="D";
        else if(localstat>=10)
            mytext.text="D-";
        else
            mytext.text="F";

    }
}
