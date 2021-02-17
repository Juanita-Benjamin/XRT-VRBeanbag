using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagController : MonoBehaviour
{
    private static BagController _instance;

    public static BagController Instance
    {
        get { return _instance; }
    }

    public GameObject beanbag;

    public Transform spawnPoint;

    private GameObject _container;

    private GameObject _bag;
    
    // Start is called before the first frame update

    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        _container = new GameObject("Bags Container");
        SpawnBag();
    }

    public void SpawnBag()
    {
        _bag = Instantiate(beanbag, spawnPoint.position, spawnPoint.rotation, _container.transform);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBag()
    {
        var bags = FindObjectsOfType<Beanbag>();

        foreach (var bag in bags)
        {
            Destroy(bag.gameObject);
        }
        SpawnBag();
    }
}
