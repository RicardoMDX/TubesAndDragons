using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    public Text text;
    public PlayerScript playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        playerScript.i_ExperiencePoints =0;
        playerScript.i_XPToNextLevel=Mathf.RoundToInt(playerScript.i_XPToNextLevel*1.5f);
        playerScript.i_Level++;
        text.text = playerScript.s_Name+" leveled up to level "+ playerScript.i_Level;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextBattleButton()
    {
        SceneManager.LoadScene("Battle");        
    }
}
