using System.Numerics;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToAmogus : MonoBehaviour
{
    public Button yourButton;

    public void start(){
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(goToAmogus);
    }

    public void goToAmogus() {
        SceneManager.LoadScene("MainScene");
    }
}
