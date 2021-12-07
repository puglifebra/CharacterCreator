using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public SpriteRenderer ArmorRenderer;
    public SpriteRenderer WeaponRenderer;
    // Start is called before the first frame update
    public void setArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }
    public void setWeapon(Sprite newSprite)
    {
        WeaponRenderer.sprite = newSprite;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
