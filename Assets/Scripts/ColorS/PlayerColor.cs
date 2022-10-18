using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    [SerializeField]private GameObject BulletPrefab;
    [SerializeField]private ColorSelector selector;

    private void Start()
    {
        selector = GetComponent<Shooter>().bulletProjPrefab.GetComponent<ColorSelector>() ;
    }

    public void setGunColor(Color col)
    {
        selector.myColor = col;
    }
}
