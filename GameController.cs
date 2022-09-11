using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Dictionary<string,int> statusdictionary=new Dictionary<string,int>{
        {"STR",0},
        {"DEX",0},
        {"CON",0},
        {"INT",0},
        {"APP",0}
    };
    
    //디버그용. 게임 에디터에서 수치를 조작할 수 있도록.
    // public int STR;
    // public int DEX;
    // public int CON;
    // public int INT;
    // public int APP;

    void Awake()
    {
        //변수 세팅
    }

    void Start() {
        GameLoad();    
    }
    // Update is called once per frame
    void Update()
    {
        //디버그용. 게임 에디터에서 수치를 조작할 수 있도록.
        // statusdictionary["STR"]=STR;
        // statusdictionary["DEX"]=DEX;
        // statusdictionary["CON"]=CON;
        // statusdictionary["INT"]=INT;
        // statusdictionary["APP"]=APP;
    }

    // 게임 저장
    public void GameSave()
    {   
        // 스테이터스 저장
        foreach (KeyValuePair<string,int> stat in statusdictionary)
        {
            PlayerPrefs.SetInt(stat.Key,stat.Value);
            Debug.Log(string.Format("{0}에 {1} 저장",stat.Key,stat.Value));
        }
        
    }

    // 게임 불러오기
    public void GameLoad()
    {
        // 스테이터스 불러오기
        var localkeys= new List<string>(statusdictionary.Keys);
        foreach (string stat in localkeys)
        {
            statusdictionary[stat]=PlayerPrefs.GetInt(stat);
        }
    }

}
