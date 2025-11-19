using UnityEngine;

public class InventoryInput : MonoBehaviour
{
    [SerializeField] private InventorySystem _inventorySystem;

    private void Update()
    {
        // --- PICKUP ---
        if (Input.GetKeyDown(KeyCode.G))
            _inventorySystem.PickupGun();
        if (Input.GetKeyDown(KeyCode.M))
            _inventorySystem.PickupMedipack();
        if (Input.GetKeyDown(KeyCode.K))
            _inventorySystem.PickupKeycard();

        // --- DROP ---
        if (Input.GetKeyDown(KeyCode.Alpha1))
            _inventorySystem.DropGun();
        if (Input.GetKeyDown(KeyCode.Alpha2))
            _inventorySystem.DropMedipack();
        if (Input.GetKeyDown(KeyCode.Alpha3))
            _inventorySystem.DropKeycard();
    }
}
