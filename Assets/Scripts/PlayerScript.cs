using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public int i_Level, i_ExperiencePoints, i_HP, i_MaxHP;
    public Slider sld_HealthSlider;

    // Start is called before the first frame update
    void Start()
    {
        sld_HealthSlider.maxValue = i_MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
