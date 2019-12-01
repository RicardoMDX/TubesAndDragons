using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public string s_Name;
    public int i_Race, i_Class, i_Level=1, i_ExperiencePoints=0, i_HP=10, i_MaxHP=10, i_Mana=3, i_MaxMana=3, i_Attack=2, i_Defend=2, i_Dodge=1;
    public Slider sld_HealthSlider, sld_ManaSlider;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        sld_HealthSlider.maxValue = i_MaxHP;
        sld_HealthSlider.value = i_HP;
        sld_ManaSlider.maxValue = i_MaxMana;
        sld_ManaSlider.value = i_Mana;
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
