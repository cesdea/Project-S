using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

   [Header("#Manager")]
    public Pool_Manager_Script PolManage;
    public Wappon_Pool_Manager_Script WaPolManage;
    public AudioManageer AudioManager;
    public UIManager uiManger;

    [Header("#PlayerInfo")]
    public Player player;
    public float speed=5;

    [HideInInspector] public float catchEnemy=0;
    [HideInInspector] public float maxGameTime;
    [HideInInspector] public float gameTime=0;
    private ConfigReader reader;


    private void Awake()
    {
        reader = new ConfigReader("Timer");
        maxGameTime = reader.Search<float>("maxTime");
        instance = this;
    }
 
    private void FixedUpdate()
    {
        gameTime += Time.fixedDeltaTime;
    }
}

//가져올 매개변수를 바탕으로 딕셔너리로 값을 모두 들고옴 
