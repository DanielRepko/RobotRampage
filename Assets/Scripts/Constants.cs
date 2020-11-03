﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used to provide other files easy access to constant values
public class Constants
{
    // Scenes
    public const string SceneBattle = "Battle";
    public const string SceneMenu = "MainMenu";

    // Gun Types
    public const string Pistol = "Pistol";
    public const string AssaultRifle = "AssaultRifle";
    public const string Shotgun = "Shotgun";

    // Robot Types
    public const string RedRobot = "RedRobot";
    public const string BlueRobot = "BlueRobot";
    public const string YellowRobot = "YellowRobot";

    // Pickup Types
    public const int PickUpPistolAmmo = 1;
    public const int PickUpAssaultRifleAmmo = 2;
    public const int PickUpShotunAmmo = 3;
    public const int PickUpHealth = 4;
    public const int PickUpArmor = 5;

    // Misc
    public const string Game = "Game";
    public const float CameraDefaultZoom = 60f;

    public static readonly int[] AllPickupTypes = new int[5]
    {
        PickUpPistolAmmo,
        PickUpAssaultRifleAmmo,
        PickUpShotunAmmo,
        PickUpHealth,
        PickUpArmor
    };

}