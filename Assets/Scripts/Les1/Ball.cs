using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameObject prefab;  
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private float ballLifetime = 2f;
    [SerializeField] private Vector3 minPosition = new Vector3(-5, 0, -5);
    [SerializeField] private Vector3 maxPosition = new Vector3(5, 5, 5);

    private float elapsedTime = 0f;

    private GameObject CreateBall(Color c, Vector3 position)
    {
        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material mat = ball.GetComponent<MeshRenderer>().material;

        mat.SetColor("_Color", c);

        if (mat.shader.name == "Universal Render Pipeline/Lit")
        {
            mat.SetColor("_BaseColor", c);
        }

        return ball;
    }

    private void DestroyBall(GameObject ball)
    {
        Destroy(ball, ballLifetime);
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnInterval)
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            Color randColor = new Color(r, g, b, 1f);

            Vector3 randomPos = new Vector3(
                Random.Range(minPosition.x, maxPosition.x),
                Random.Range(minPosition.y, maxPosition.y),
                Random.Range(minPosition.z, maxPosition.z)
            );

            GameObject ball = CreateBall(randColor, randomPos);
            DestroyBall(ball);

            elapsedTime = 0f;
        }
    }
}
