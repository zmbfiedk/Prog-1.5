using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab;
    [SerializeField] private LayerMask groundLayer;  

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnTowerAtClick();
        }
    }

    private void SpawnTowerAtClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, groundLayer))
        {
            Vector3 spawnPosition = hit.point;
            Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
