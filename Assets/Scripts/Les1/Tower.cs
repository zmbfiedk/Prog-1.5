using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("Tower Scale Range")]
    public Vector3 minScale = new Vector3(1f, 1f, 1f);
    public Vector3 maxScale = new Vector3(3f, 3f, 3f);

    void Start()
    {
        RandomizeScale();
    }

    private void RandomizeScale()
    {
        // Randomize each axis separately
        float randomX = Random.Range(minScale.x, maxScale.x);
        float randomY = Random.Range(minScale.y, maxScale.y);
        float randomZ = Random.Range(minScale.z, maxScale.z);

        transform.localScale = new Vector3(randomX, randomY, randomZ);
    }
}
