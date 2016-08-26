using UnityEngine;
using System.Collections;

public class EnergyPerSec : MonoBehaviour {

    public UnityEngine.UI.Text energyDisplay;
    public Click click;
    public ItemManager[] items;

    void Start() {
        StartCoroutine(AutoTick());
    }

    void Update() {
        energyDisplay.text = GetEnergyPerSec() + " energy/sec";
    }


    public float GetEnergyPerSec() {
        float tick = 0;
        foreach(ItemManager item in items){
            tick += item.count * item.tickValue;
        }
        return tick;
    }
	
    public void AutoEnergyPerSec() {
        click.energy += GetEnergyPerSec()/10;
    }

    IEnumerator AutoTick() {
        while (true) {
            AutoEnergyPerSec();
            yield return new WaitForSeconds(.1f);
        }
    }

}
