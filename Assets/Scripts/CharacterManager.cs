using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;

public class PlanesDB : MonoBehaviour{
    public Planes planesDB;

    public static int selection = 0;
    public SpriteRenderer sprite;
    
    private void Start(){
        updateCharacter();
    }
    public void updateCharacter(){
        Plane current = planesDB.getPlane(selection);
        sprite.sprite = current.prefab.GetComponentInChildren<SpriteRenderer>().sprite;
    }
    public void next(){
        int numberPins = planesDB.count();
        if (selection < numberPins - 1)
        {
            selection = selection + 1;
        }
        else
        {
            selection = 0;
        }
        updateCharacter();
    }
    public void previous()
    {
        if (selection > 0)
        {
            selection = selection - 1;
        }
        else
        {
            selection = planesDB.count() - 1;
        }
        updateCharacter();
    }
}
