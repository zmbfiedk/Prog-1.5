using UnityEngine;

/// <summary>
/// Handles player input for picking up and dropping items.
/// </summary>
public class InventoryInput : MonoBehaviour
{
    [SerializeField] private InventorySystem _inventorySystem;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            _inventorySystem.AddItem(new WeaponItem());
            _inventorySystem.PrintInventory();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            _inventorySystem.AddItem(new MedipackItem());
            _inventorySystem.PrintInventory();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            _inventorySystem.AddItem(new KeycardItem());
            _inventorySystem.PrintInventory();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _inventorySystem.RemoveItem<WeaponItem>();
            _inventorySystem.PrintInventory();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _inventorySystem.RemoveItem<MedipackItem>();
            _inventorySystem.PrintInventory();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _inventorySystem.RemoveItem<KeycardItem>();
            _inventorySystem.PrintInventory();
        }
    }
}
