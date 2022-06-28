using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{
    public Text totalClicksText;

    int totalClicks;

    public void OnMouseUp()
    {
        totalClicksText.text = totalClicksText.ToString();
    }
}
