using System.Numerics;
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Vector2;

public class Shop : MonoBehaviour
{
    public void goToShop() {
        Camera.main.transform.Translate(50,50,50);
    }
}
