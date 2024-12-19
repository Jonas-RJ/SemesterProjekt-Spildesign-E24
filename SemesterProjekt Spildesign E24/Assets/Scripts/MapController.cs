using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public PauseScreenManager _PSManager;
    public GameObject emilMap;
    public GameObject martinMap;
    public GameObject kenniMap;
    public GameObject jonasMap;

    [SerializeField] private int mapSelector;

    void Start()
    {
        Time.timeScale = 1;
        mapSelector = Random.Range(0, 4);
        gameObject.SetActive(false);
        switch (mapSelector)
        {
            case 0:
                emilMap.SetActive(false);
                kenniMap.SetActive(false);
                martinMap.SetActive(false);
                jonasMap.SetActive(true);
                break;          
            case 1:
                emilMap.SetActive(false);
                kenniMap.SetActive(false);
                martinMap.SetActive(true);
                jonasMap.SetActive(false);
                break;
            case 2:
                emilMap.SetActive(false);
                kenniMap.SetActive(true);
                martinMap.SetActive(false);
                jonasMap.SetActive(false);
                break;
            case 3:
                emilMap.SetActive(true);
                kenniMap.SetActive(false);
                martinMap.SetActive(false);
                jonasMap.SetActive(false);
                break;
        }
    }
}
