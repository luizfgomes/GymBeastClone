using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterOutfitController : MonoBehaviour
{
    [SerializeField] private Outfit[] isEnabledGlasses; 
    [SerializeField] private Outfit[] isEnabledHat; 
    [SerializeField] private Outfit[] isEnabledHair;
    [SerializeField] private Outfit[] isEnabledBackPack;
    [SerializeField] private Outfit[] isEnabledHeadphones;
    [SerializeField] private Outfit[] isEnabledNecktie;
    [SerializeField] private Outfit[] isEnabledClothes;

    private void Start ()
    {
        for(int i = 0; i < isEnabledGlasses.Length; i++ )
        {
            isEnabledGlasses[i].outfit.SetActive(isEnabledGlasses[i].isEnabled);
        }

        for ( int i = 0; i < isEnabledHat.Length; i++ )
        {
            isEnabledHat[i].outfit.SetActive(isEnabledHat[i].isEnabled);
        }

        for ( int i = 0; i < isEnabledHair.Length; i++ )
        {
            isEnabledHair[i].outfit.SetActive(isEnabledHair[i].isEnabled);
        }

        for ( int i = 0; i < isEnabledBackPack.Length; i++ )
        {
            isEnabledBackPack[i].outfit.SetActive(isEnabledBackPack[i].isEnabled);
        }

        for ( int i = 0; i < isEnabledHeadphones.Length; i++ )
        {
            isEnabledHeadphones[i].outfit.SetActive(isEnabledHeadphones[i].isEnabled);
        }

        for ( int i = 0; i < isEnabledNecktie.Length; i++ )
        {
            isEnabledNecktie[i].outfit.SetActive(isEnabledNecktie[i].isEnabled);
        }

        for ( int i = 0; i < isEnabledClothes.Length; i++ )
        {
            isEnabledClothes[i].outfit.SetActive(isEnabledClothes[i].isEnabled);
        }
    }
}

[System.Serializable]
public class Outfit
{
    public bool isEnabled;
    public GameObject outfit;
}