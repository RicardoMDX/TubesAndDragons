using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public int i_Hitpoints, i_Level, i_Attack;
    public Slider sld_HealthSlider;

    // Start is called before the first frame update
    void Start()
    {
        sld_HealthSlider = GetComponentInChildren<Slider>();
        sld_HealthSlider.maxValue = i_Hitpoints;
        sld_HealthSlider.value = i_Hitpoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
