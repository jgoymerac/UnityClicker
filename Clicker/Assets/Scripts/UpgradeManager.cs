using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

    public Click click;

    public UnityEngine.UI.Text itemInfo;
    public double cost;
    public int count=0;
    public int clickPower;
    public string itemName;
    public Color standard;
    public Color affordable;
    public double baseCost;
    private Slider _slider;

    void Start() {
        baseCost = cost;
        _slider = GetComponentInChildren<Slider>();
    }


    void Update() {
        itemInfo.text = itemName + " (" + count + ")" + " \nCost: " + cost + "\nPower: +" + clickPower;
        /* if (click.energy >= cost) {
             GetComponent<Image>().color = affordable;
         } else {
             GetComponent<Image>().color = standard;
         }*/
        _slider.value = (float)click.energy / (float)cost * 100;

    }

    public void PurchasedUpgrade() {
        if (click.energy >= cost) {
            click.energy -= cost;
            count++;
            click.energyPerClick += clickPower;
            cost = System.Math.Round(baseCost * Mathf.Pow(1.15f, count));
        }
    }


	
	
}
