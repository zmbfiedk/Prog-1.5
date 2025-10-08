using UnityEngine;

public class ShootFromCamera : MonoBehaviour
{
    public GameObject projectilePrefab; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Vector3 targetPos;
            if (Physics.Raycast(ray, out hit))
            {
                targetPos = hit.point;
            }
            else
            {
                targetPos = ray.GetPoint(100f);
            }

            GameObject p = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            p.transform.LookAt(targetPos);

            p.AddComponent<MoveProj>();
            Destroy(p, 5f);
        }
    }
}
