using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject emilMap;
    public GameObject martinMap;
    public GameObject kenniMap;
    public GameObject jonasMap;

    [SerializeField] private int mapSelector;

    void Start()
    {
        mapSelector = Random.Range(0, 4);
        print(mapSelector);
        gameObject.SetActive(false);
        switch (mapSelector)
        {
            case 0:
                emilMap.SetActive(false);
                kenniMap.SetActive(false);
                martinMap.SetActive(false);
                jonasMap.SetActive(true);
                print("jonas map");
                break;          
            case 1:
                emilMap.SetActive(false);
                kenniMap.SetActive(false);
                martinMap.SetActive(true);
                jonasMap.SetActive(false);
                print("martin map");
                break;
            case 2:
                emilMap.SetActive(false);
                kenniMap.SetActive(true);
                martinMap.SetActive(false);
                jonasMap.SetActive(false);
                print("Kenni map");
                break;
            case 3:
                emilMap.SetActive(true);
                kenniMap.SetActive(false);
                martinMap.SetActive(false);
                jonasMap.SetActive(false);
                print("Emil map");

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
