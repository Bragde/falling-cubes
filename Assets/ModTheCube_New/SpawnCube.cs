using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCubes();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnCubes()
    {
        Vector3 pos = new Vector3(Random.Range(-100, 100), Random.Range(10, 100), Random.Range(-100, 100));
        Instantiate(cubePrefab, pos, cubePrefab.transform.rotation);
        Invoke("SpawnCubes", 10f * Time.deltaTime);
        Debug.Log("Spawn cube!");
    }
}
