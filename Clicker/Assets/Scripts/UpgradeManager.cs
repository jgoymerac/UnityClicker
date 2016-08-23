using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour {

    public Click click;

    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count=0;
    public int clickPower;
    public string itemName;
    public float baseCost;
    
    void Start() {
        baseCost = cost;
    }


    void Update() {
        itemInfo.text = itemName + " \nCost: " + cost + "\nPower: +" + clickPower;
    }

    public void PurchasedUpgrade() {
        if (click.energy >= cost) {
            click.energy -= cost;
            count++;
            click.energyPerClick += clickPower;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
        }
    }


	
	
}
