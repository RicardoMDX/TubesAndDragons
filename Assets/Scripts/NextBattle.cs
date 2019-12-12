using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextBattle : MonoBehaviour
{
    public Text text;
    public Button nextBattleButton, levelUpButton;
    public PlayerScript playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        playerScript.i_ExperiencePoints += Mathf.RoundToInt(playerScript.i_BattleXP*playerScript.f_XPMultiplier);
        text.text = "You gained " + playerScript.i_BattleXP + "XP!";
        if(playerScript.i_ExperiencePoints>=playerScript.i_XPToNextLevel)
        {
            nextBattleButton.transform.gameObject.SetActive(false);
            levelUpButton.transform.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextBattleButton()
    {
        SceneManager.LoadScene("Battle");
    }

    public void LevelUp()
    {
        SceneManager.LoadScene("LevelUp");
    }
}
