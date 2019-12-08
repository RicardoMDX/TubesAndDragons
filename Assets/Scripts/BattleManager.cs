using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{

    public Text txt_Header;
    public Button[] bu_Buttons = new Button[3];
    public GameObject[] go_Spawns=new GameObject [5];
    public GameObject go_EnemyLvl1, go_EnemyLvl2, go_EnemyLvl3, go_EnemyLvl4, go_EnemyLvl5, 
        go_EnemyLvl6, go_EnemyLvl7, go_EnemyLvl8, go_EnemyLvl9, go_EnemyLvl10, go_EnemyLvl11, 
        go_EnemyLvl12, go_EnemyLvl13, go_EnemyLvl14, go_EnemyLvl15, go_EnemyLvl16, go_EnemyLvl17, 
        go_EnemyLvl18, go_EnemyLvl19, go_EnemyLvl20;
    public PlayerScript playerScript;

    private int i_PlayerLevel=0, i_EnemyToSpawn, i_EnemiesLevels=0, i=0;
    private bool b_PlayerTurn=true;
    private GameObject[] i_Enemies = new GameObject[5];

    // Start is called before the first frame update
    void Start()
    { 
        //Setup player
        playerScript=GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        i_PlayerLevel = playerScript.i_Level;
        playerScript.sld_HealthSlider.maxValue = playerScript.f_MaxHP;
        playerScript.sld_HealthSlider.value = playerScript.f_HP;
        playerScript.sld_ManaSlider.maxValue = playerScript.f_MaxMana;
        playerScript.sld_ManaSlider.value = playerScript.f_Mana;
        Debug.Log("Player Level: "+i_PlayerLevel);

        //Setup enemies
        while ((i_PlayerLevel-i_EnemiesLevels)>=1 && i<5)
        {
            Debug.Log("Level difference= " + (i_PlayerLevel - i_EnemiesLevels));
            //Decide Enemy Level
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
            //Add Enemy To Array
            switch (i_EnemyToSpawn)
            {
                case 1:
                    i_Enemies[i] = go_EnemyLvl1;
                    break;
                case 2:
                    i_Enemies[i] = go_EnemyLvl2;
                    break;
                case 3:
                    i_Enemies[i] = go_EnemyLvl3;
                    break;
                case 4:
                    i_Enemies[i] = go_EnemyLvl4;
                    break;
                case 5:
                    i_Enemies[i] = go_EnemyLvl5;
                    break;
                case 6:
                    i_Enemies[i] = go_EnemyLvl6;
                    break;
                case 7:
                    i_Enemies[i] = go_EnemyLvl7;
                    break;
                case 8:
                    i_Enemies[i] = go_EnemyLvl8;
                    break;
                case 9:
                    i_Enemies[i] = go_EnemyLvl9;
                    break;
                case 10:
                    i_Enemies[i] = go_EnemyLvl10;
                    break;
                case 11:
                    i_Enemies[i] = go_EnemyLvl11;
                    break;
                case 12:
                    i_Enemies[i] = go_EnemyLvl12;
                    break;
                case 13:
                    i_Enemies[i] = go_EnemyLvl13;
                    break;
                case 14:
                    i_Enemies[i] = go_EnemyLvl14;
                    break;
                case 15:
                    i_Enemies[i] = go_EnemyLvl15;
                    break;
                case 16:
                    i_Enemies[i] = go_EnemyLvl16;
                    break;
                case 17:
                    i_Enemies[i] = go_EnemyLvl17;
                    break;
                case 18:
                    i_Enemies[i] = go_EnemyLvl18;
                    break;
                case 19:
                    i_Enemies[i] = go_EnemyLvl19;
                    break;
                case 20:
                    i_Enemies[i] = go_EnemyLvl20;
                    break;
            }        
            i_EnemiesLevels += i_EnemyToSpawn;
            Debug.Log("Enemy LVL:" + i_EnemyToSpawn + " Enemies LVL total:" + i_EnemiesLevels);            
            i++;
        }
        i = 0;
        foreach (GameObject s in go_Spawns)
        {
            Instantiate(i_Enemies[i],s.transform);
            Debug.Log("Spawning enemy " + i + " in spawn " + s);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!b_PlayerTurn)
        {
            foreach(Button b in bu_Buttons)
            {
                b.interactable = false;
            }
            //Enemies turn
        }
        else
        {
            foreach (Button b in bu_Buttons)
            {
                b.interactable = true;
            }
        }
    }

    public void Attack()
    {

    }
}