using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterCreation : MonoBehaviour
{
    public InputField nameField;
    public Toggle raceButton1, raceButton2, raceButton3, raceButton4;
    public Toggle classButton1, classButton2, classButton3, classButton4;
    public PlayerScript playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Done()
    {
        int i_race=0, i_class=0;
        string s_name;
        s_name = nameField.text;
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
        if(s_name.Length<3 || i_race==0 || i_class==0)
        {
            Debug.Log("Error");
        }
        else
        {
            playerScript.s_Name = s_name;
            playerScript.i_Race = i_race;
            playerScript.i_Class = i_class;
            Debug.Log("Name= "+s_name+" Race= " + i_race + " and Class= " + i_class);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
