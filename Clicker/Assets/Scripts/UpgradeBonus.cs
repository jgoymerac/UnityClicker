using UnityEngine;
using System.Collections;

public class UpgradeBonus : MonoBehaviour {

    public Click click;
    public float cost;
    public float power;
    public string itemName;
    public UpgradeManager _count;

    void Start() {
        _count = GetComponentInParent<UpgradeManager>();
    }
    void Update() {

    }
    public void PurchasedUpgrade() {
        if (click.energy >= cost) {
            click.energy -= cost;
            click.energyPerClick += _count.count * _count.clickPower;
            _count.clickPower *= 2;
        }
    }



}
