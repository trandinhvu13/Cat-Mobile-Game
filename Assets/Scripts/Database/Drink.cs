﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Drink", menuName = "ScriptableObjects/Drink")]
public class Drink : ScriptableObject, IInventory
{
    public int ColorID { get; set; }
    public int Quantity { get; set; }
    public int MaxQuantity { get; set; }
    public string Type { get => Type; set => Type = "Drink"; }
    public Sprite playerInventory;
    public Sprite order;
    public Sprite cup;

}
