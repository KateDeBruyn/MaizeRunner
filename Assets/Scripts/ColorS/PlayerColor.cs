using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    private GameObject BulletPrefab;
    private ColorSelector selector;

    private void Start()
    {
        selector = GetComponent<ShooterControls>().bulletProjPrefab.GetComponent<ColorSelector>() ;
    }

    public void setGunColor(Color col)
    {
        selector.myColor = col;
    }
}
