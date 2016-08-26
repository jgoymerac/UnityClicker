using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    private float baseCost;

    void Start() {
        baseCost = cost;
    }

    void Update() {
        itemInfo.text = itemName +" ("+count+")"+ "\nCost: " + cost + "\nEnergy: " + tickValue + "/s";
    }

    public void PurchasedItem() {
        if (click.energy >= cost) {
            click.energy -= cost;
            count++;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
        }
    }


}
