using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextBattle : MonoBehaviour
{
    public Text text;
    public PlayerScript playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        text.text = "You gained " + playerScript.i_BattleXP + "XP!";
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
