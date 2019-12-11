using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public string s_Name;
    public int i_Race, i_Class, i_Level=1, i_ExperiencePoints=0, i_Attack=2, i_Defend=2, i_BattleXP=0;
    public float f_XPMultiplier = 1f, f_PriceMultiplier=1f, f_HPMultiplier=1f, f_MPMultiplier=1f, f_Dodge=0.1f, f_HP = 10, f_Mana = 4, f_MaxHP = 10, f_MaxMana = 4;
    public Slider sld_HealthSlider, sld_ManaSlider;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Update Text
        GetComponentInChildren<Text>().text = s_Name + " Lvl." + i_Level;

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            gameObject.transform.position = GameObject.Find("PlayerSpawn").transform.position;
        }
    }
}
