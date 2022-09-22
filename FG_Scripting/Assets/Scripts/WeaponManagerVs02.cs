using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponManagerVs02 : MonoBehaviour
{
    [SerializeField] private float fireRate;
    private float fireRateTimer;
    [SerializeField] private bool semiAuto;
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform barrelPos;
    [SerializeField] private float bulletVelocity;
    

    private void Start()
    {
        fireRateTimer = fireRate;
    }

    private void Update()
    {
        throw new NotImplementedException();
    }

    bool ShouldFire()
    {
        fireRateTimer += Time.deltaTime;
        if(fireRateTimer<fireRate) return false
        if (semiAuto&&Input.GetKeyDown(KeyCode.Mouse0)) return true ;
        if (!semiAuto&&Input.GetKey(KeyCode.Mouse0)) return true ;
        return false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            bool IsPlayerTurn = playerTurn.IsPlayerTurn();
            if (IsPlayerTurn)
}
