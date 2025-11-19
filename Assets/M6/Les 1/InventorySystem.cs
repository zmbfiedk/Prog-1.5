using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // WORLD ITEM COUNTS
    [SerializeField] private int _worldMedipacks = 4;
    [SerializeField] private int _worldGuns = 2;
    [SerializeField] private int _worldKeycards = 1;

    // PLAYER INVENTORY ITEMS
    private List<InventoryItem> _inventory = new List<InventoryItem>();

    // -------- PICKUP --------
    public void PickupGun()
    {
        if (_worldGuns > 0)
        {
            _worldGuns--;
            _inventory.Add(new WeaponItem());
            Debug.Log("Picked up a gun!");
            PrintInventories();
        }
    }

    public void PickupMedipack()
    {
        if (_worldMedipacks > 0)
        {
            _worldMedipacks--;
            _inventory.Add(new MedipackItem());
            Debug.Log("Picked up a medipack!");
            PrintInventories();
        }
    }

    public void PickupKeycard()
    {
        if (_worldKeycards > 0)
        {
            _worldKeycards--;
            _inventory.Add(new KeycardItem());
            Debug.Log("Picked up a keycard!");
            PrintInventories();
        }
    }

    // -------- DROP --------
    public void DropGun()
    {
        InventoryItem gun = _inventory.Find(item => item is WeaponItem);
        if (gun != null)
        {
            _inventory.Remove(gun);
            _worldGuns++;
            Debug.Log("Dropped a gun!");
            PrintInventories();
        }
    }

    public void DropMedipack()
    {
        InventoryItem medipack = _inventory.Find(item => item is MedipackItem);
        if (medipack != null)
        {
            _inventory.Remove(medipack);
            _worldMedipacks++;
            Debug.Log("Dropped a medipack!");
            PrintInventories();
        }
    }

    public void DropKeycard()
    {
        InventoryItem keycard = _inventory.Find(item => item is KeycardItem);
        if (keycard != null)
        {
            _inventory.Remove(keycard);
            _worldKeycards++;
            Debug.Log("Dropped a keycard!");
            PrintInventories();
        }
    }

    // -------- PRINTING --------
    private void PrintInventories()
    {
        int invMedipacks = 0;
        int invGuns = 0;
        int invKeycards = 0;

        foreach (InventoryItem item in _inventory)
        {
            if (item is MedipackItem) invMedipacks++;
            if (item is WeaponItem) invGuns++;
            if (item is KeycardItem) invKeycards++;
        }

        Debug.Log("nitems in de wereld:");
        Debug.Log($"medipacks : {_worldMedipacks}");
        Debug.Log($"guns : {_worldGuns}");
        Debug.Log($"keycards : {_worldKeycards}");
        Debug.Log("Items in inventory:");
        Debug.Log($"medipacks : {invMedipacks}");
        Debug.Log($"guns : {invGuns}");
        Debug.Log($"keycards : {invKeycards}");
    }
}
