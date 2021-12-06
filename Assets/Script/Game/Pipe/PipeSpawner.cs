using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Input")]
    [SerializeField] float spawnInterval = 1;
    [SerializeField] GameObject pipePrefab;
    [SerializeField] float randomHeight;

    // fields
    private float _timer = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > spawnInterval)
        {
            GameObject newpipe = Instantiate(pipePrefab);
            newpipe.transform.position = transform.position + new Vector3(
                0,
                Random.Range(-randomHeight, randomHeight),
                0);
            Destroy(newpipe, 5);
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }


    
}
