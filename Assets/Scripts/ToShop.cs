using System.Numerics;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToShop : MonoBehaviour
{   
    public Button yourButton;

    public void start(){
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(goToShop);
    }

    public void goToShop() {
        SceneManager.LoadScene("ShopScene");
    }
}
