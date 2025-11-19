using UnityEngine;

/// <summary>
/// Base class for all inventory items.
/// Contains shared properties.
/// </summary>
public abstract class InventoryItem
{
    public string ItemName { get; protected set; }
}
