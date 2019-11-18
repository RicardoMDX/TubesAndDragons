using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{

    public Text txt_Header;
    public GameObject go_Spawn1, go_Spawn2, go_Spawn3, go_Spawn4, go_Spawn5;
    public GameObject go_EnemyLvl1, go_EnemyLvl2, go_EnemyLvl3, go_EnemyLvl4, go_EnemyLvl5;
    private GameObject go_Player;

    // Start is called before the first frame update
    void Start()
    {
        go_Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
