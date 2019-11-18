using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreation : MonoBehaviour
{
    public Toggle raceButton1, raceButton2, raceButton3, raceButton4;
    public Toggle classButton1, classButton2, classButton3, classButton4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Done()
    {
        int i_race=0, i_class=0;
        if(raceButton1.isOn)
        {
            i_race = 1;
        }
        if (raceButton2.isOn)
        {
            i_race = 2;
        }
        if (raceButton3.isOn)
        {
            i_race = 3;
        }
        if (raceButton4.isOn)
        {
            i_race = 4;
        }
        if(classButton1.isOn)
        {
            i_class = 1;
        }
        if (classButton2.isOn)
        {
            i_class = 2;
        }
        if (classButton3.isOn)
        {
            i_class = 3;
        }
        if (classButton4.isOn)
        {
            i_class = 4;
        }
        if(i_race==0 || i_class==0)
        {
            Debug.Log("Error");
        }
        else
        {
            Debug.Log("Race= " + i_race + " and Class= " + i_class);
        }
    }

    public void RandomPicks()
    {
        int random;
        random = Random.Range(1, 5);
        switch (random)
        {
            case 1: raceButton1.isOn = true; break;
            case 2: raceButton2.isOn = true; break;
            case 3: raceButton3.isOn = true; break;
            case 4: raceButton4.isOn = true; break;
        }
        random = Random.Range(1, 4);
        switch (random)
        {
            case 1: classButton1.isOn = true; break;
            case 2: classButton2.isOn = true; break;
            case 3: classButton3.isOn = true; break;
            case 4: classButton4.isOn = true; break;
        }
    }
}
