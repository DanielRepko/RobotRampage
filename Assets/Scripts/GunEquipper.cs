using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEquipper : MonoBehaviour
{
    public static string activeWeaponType;

    // GameObject fields to hold the gun objects
    public GameObject pistol;
    public GameObject assaultRifle;
    public GameObject shotgun;

    public GameObject activeGun;


    // Start is called before the first frame update
    void Start()
    {
        // initializing the starting gun to be the pistol
        activeWeaponType = Constants.Pistol;
        LoadWeapon(pistol);
    }


    // Update is called once per frame
    void Update()
    {
        // checking which key has been pressed and changing the active weapon accordingly
        if (Input.GetKeyDown("1"))
        {
            LoadWeapon(pistol);
            activeWeaponType = Constants.Pistol;
        }
        else if (Input.GetKeyDown("2"))
        {
            LoadWeapon(assaultRifle);
            activeWeaponType = Constants.AssaultRifle;
        }
        else if (Input.GetKeyDown("3"))
        {
            LoadWeapon(shotgun);
            activeWeaponType = Constants.Shotgun;
        }
    }

    public GameObject GetActiveWeapon()
    {
        return activeGun;
    }

    private void LoadWeapon(GameObject weapon)
    {
        pistol.SetActive(false);
        assaultRifle.SetActive(false);
        shotgun.SetActive(false);

        weapon.SetActive(true);
        activeGun = weapon;
    }
}
