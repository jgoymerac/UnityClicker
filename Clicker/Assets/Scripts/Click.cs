﻿using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
    public UnityEngine.UI.Text energyDisplay;
    public UnityEngine.UI.Text epcDisplay;
    public double energy=0.00d;
    public int energyPerClick=1;

    void Update() {
        energyDisplay.text = "Energy: " + energy.ToString("F0");
        epcDisplay.text = $"{energyPerClick} Energy/click";
    }

    public void Clicked() {
        energy += energyPerClick;
        
    }
}
