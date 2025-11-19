using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stores and manages a collection of inventory items.
/// </summary>
public class InventorySystem : MonoBehaviour
{
    // 1. Fields
    private List<InventoryItem> _items = new List<InventoryItem>();

    // 2. Public Methods
    public void AddItem(InventoryItem item)
    {
        _items.Add(item);
        Debug.Log($"Picked up a {item.ItemName}!");
    }

    public void RemoveItem<T>() where T : InventoryItem
    {
        InventoryItem itemToRemove = _items.Find(item => item is T);

        if (itemToRemove != null)
        {
            _items.Remove(itemToRemove);
            Debug.Log($"Dropped a {itemToRemove.ItemName}!");
        }
        else
        {
            Debug.Log($"You don't have a {typeof(T).Name} to drop!");
        }
    }

    public void PrintInventory()
    {
        Debug.Log("=== INVENTORY ===");

        if (_items.Count == 0)
        {
            Debug.Log("Inventory is empty.");
            return;
        }

        Dictionary<string, int> counts = new Dictionary<string, int>();

        foreach (InventoryItem item in _items)
        {
            if (!counts.ContainsKey(item.ItemName))
                counts[item.ItemName] = 0;

            counts[item.ItemName]++;
        }

        foreach (var entry in counts)
        {
            Debug.Log($"{entry.Key}: {entry.Value}");
        }
    }
}
