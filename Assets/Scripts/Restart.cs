using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    private PlayerScript playerScript;
    public Text text1, text2;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        text1.text = playerScript.s_Name+" died at Level "+playerScript.i_Level+",";
        text2.text = "he was a " + GetRace() + " " + GetClass()+".";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        SceneManager.LoadScene(0);
    }

    string GetRace()
    {
        switch(playerScript.i_Race)
        {
            case 1:
                return "Human";
            case 2:
                return "Dwarf";
            case 3:
                return "Orc";
            case 4:
                return "Elf";
            default:
                return "Error";
        }
    }
    string GetClass()
    {
        switch (playerScript.i_Class)
        {
            case 1:
                return "Warrior";
            case 2:
                return "Ranger";
            case 3:
                return "Rogue";
            case 4:
                return "Mage";
            default:
                return "Error";
        }
    }
}
