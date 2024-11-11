
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<10; i++)
        {
            //Instantiate(prefab);
            //Instantiate(prefab, transform.position, transform.rotation);
            Vector3 vector = new Vector3(1f*5*i, 1f, 1f);
            Instantiate(prefab, vector, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
