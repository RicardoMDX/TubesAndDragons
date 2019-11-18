using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    private Toggle thisToggle;
    // Start is called before the first frame update
    void Start()
    {
        thisToggle = GetComponentInParent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (thisToggle.isOn)
        {
            var colors = GetComponent<Toggle>().colors;
            colors.normalColor = Color.green;
            colors.highlightedColor = Color.green;
            GetComponent<Toggle>().colors = colors;
        }
        else
        {
            var colors = GetComponent<Toggle>().colors;
            colors.normalColor = Color.white;
            colors.highlightedColor = Color.white;
            GetComponent<Toggle>().colors = colors;
        }
    }
}
