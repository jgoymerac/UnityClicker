using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeBonus : MonoBehaviour {

    public Click click;
    public double cost;
    public double power;
    public double numItems;
    public string itemName;
    public UpgradeManager _count;
    private bool purchased = false;

    void Start() {
        _count = GetComponentInParent<UpgradeManager>();
        gameObject.GetComponent<Button>().interactable = false;
       

    }
    void Update() {
        if (_count.count >= numItems / 2&&purchased ==false) {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
    public void PurchasedUpgrade() {
        

        if (click.energy >= cost && _count.count>=numItems) {
            click.energy -= cost;
            click.energyPerClick += _count.count * _count.clickPower;
            _count.clickPower *= 2;
            gameObject.GetComponent<Button>().interactable = false;
            purchased = true;
        }
    }



}
