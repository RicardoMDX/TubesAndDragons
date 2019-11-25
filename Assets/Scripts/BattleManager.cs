using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{

    public Text txt_Header;
    public GameObject go_Spawn1, go_Spawn2, go_Spawn3, go_Spawn4, go_Spawn5;
    public GameObject go_EnemyLvl1, go_EnemyLvl2, go_EnemyLvl3, go_EnemyLvl4, go_EnemyLvl5;
    public PlayerScript playerScript;

    private int i_PlayerLevel, i_EnemyToSpawn, i_EnemiesLevels=0, i=0;
    private GameObject[] i_Enemies;

    // Start is called before the first frame update
    void Start()
    { 
        playerScript=GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        i_PlayerLevel = playerScript.i_Level;
        Debug.Log(i_PlayerLevel);
        while (i_EnemiesLevels<i_PlayerLevel || i_Enemies.Length<5)
        {
            switch (i_PlayerLevel-i_EnemiesLevels)
            {
                case 1:
                case 2:
                    i_EnemyToSpawn=Random.Range(1, 2);
                    break;
                case 3:
                case 4:
                    i_EnemyToSpawn = Random.Range(1, 4);
                    break;
                case 5:
                case 6:
                    i_EnemyToSpawn = Random.Range(2, 6);
                    break;
                case 7:
                case 8:
                    i_EnemyToSpawn = Random.Range(2, 8);
                    break;
                case 9:
                case 10:
                    i_EnemyToSpawn = Random.Range(3, 10);
                    break;
                case 11:
                case 12:
                    i_EnemyToSpawn = Random.Range(3, 12);
                    break;
                case 13:
                case 14:
                    i_EnemyToSpawn = Random.Range(4, 14);
                    break;
                case 15:
                case 16:
                    i_EnemyToSpawn = Random.Range(4, 16);
                    break;
                case 17:
                case 18:
                    i_EnemyToSpawn = Random.Range(5, 18);
                    break;
                case 19:
                case 20:
                    i_EnemyToSpawn = Random.Range(6, 20);
                    break;
            }
            i_EnemiesLevels += i_EnemyToSpawn;
            i_Enemies[i] = "go_EnemyLvl"+i_EnemyToSpawn;
        }
        foreach (int i in i_Enemies)
        {
            Instantiate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
