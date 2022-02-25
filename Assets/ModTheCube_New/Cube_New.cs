using UnityEngine;

public class Cube_New : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float[] colors = new float[4];
    Vector3 rotation;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-100, 100), Random.Range(10, 100), Random.Range(-100, 100));
        transform.localScale = Vector3.one * 1.3f;

        Material material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

        ChangeColor();
        ChangeRotation();
    }

    void Update()
    {
        transform.Rotate(rotation);

        if (transform.position.y < -1) Destroy(gameObject);
    }

    void ChangeColor()
    {
        colors[0] = Random.Range(0f, 1f);
        colors[1] = Random.Range(0f, 1f);
        colors[2] = Random.Range(0f, 1f);
        colors[3] = Random.Range(0.1f, 0.5f);
        Material material = Renderer.material;
        material.color = new Color(colors[0], colors[1], colors[2], colors[3]);

        Invoke("ChangeColor", Random.Range(0.1f, 1));
    }

    void ChangeRotation()
    {
        float X = Random.Range(-1, 1) * Time.deltaTime * Random.Range(1, 100);
        float Y = Random.Range(-1, 1) * Time.deltaTime * Random.Range(1, 100);
        float Z = Random.Range(-1, 1) * Time.deltaTime * Random.Range(1, 100);
        rotation = new Vector3(X, Y, Z);

        Invoke("ChangeRotation", Random.Range(0.1f, 1));
    }
}
