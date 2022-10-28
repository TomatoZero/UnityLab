using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnebleManager : MonoBehaviour
{
    [SerializeField] private ARRaycastManager raycastManager;
    [SerializeField] private List<GameObject> spawnablePrefabs;
    [SerializeField] private TextMeshProUGUI text;
    
    private GameObject spawnablePrefab;
    private int currentObject;
    
    private List<ARRaycastHit> _hitList = new List<ARRaycastHit>();
    private Camera _arCam;
    private GameObject _spawnedObject;
    
    private void Start() 
    {
        if(spawnablePrefabs == null)
            return;
        
        spawnablePrefab = spawnablePrefabs[0];
        currentObject = 0;
        text.text = currentObject.ToString();
        
        _spawnedObject = null;
        _arCam = GameObject.Find("AR Camera").GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.touchCount == 0)
            return;

        RaycastHit hit;
        var ray = _arCam.ScreenPointToRay(Input.GetTouch(0).position);

        if(raycastManager.Raycast(Input.GetTouch(0).position, _hitList)) 
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began && _spawnedObject == null) 
            {
                if(Physics.Raycast(ray, out hit)) 
                {
                    if(hit.collider.gameObject.tag == "Spawnable") 
                    {
                        _spawnedObject = hit.collider.gameObject;
                    }
                    else
                    {
                        SpawnPrefab(_hitList[0].pose.position);
                    }
                }
            }
            else if(Input.GetTouch(0).phase == TouchPhase.Moved && _spawnedObject != null) 
            {
                _spawnedObject.transform.position = _hitList[0].pose.position;
            }
            
            if(Input.GetTouch(0).phase == TouchPhase.Ended) 
            {
                _spawnedObject = null;
            }
        }
    }

    private void SpawnPrefab(Vector3 spawnPoint) 
    {
        _spawnedObject = Instantiate(spawnablePrefab, spawnPoint, Quaternion.identity);
    }

    public void SpawnNext(bool spawnNext)
    {
        if(spawnNext)
            if (currentObject < spawnablePrefabs.Count - 1)
            {
                currentObject++;
                spawnablePrefab = spawnablePrefabs[currentObject];
            }
            else
            {
                currentObject = 0;
                spawnablePrefab = spawnablePrefabs[currentObject];
            }
        else
            if (currentObject > 0)
            {
                currentObject--;
                spawnablePrefab = spawnablePrefabs[currentObject];
            }
            else
            {
                currentObject = 0;
                spawnablePrefab = spawnablePrefabs[currentObject];
            }

        text.text = currentObject.ToString();
    }
}
