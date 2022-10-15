using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropdownHandler : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();

    private GameObject currentActive;

    void Start()
    {
        var dropdown = GetComponent<TMP_Dropdown>();
        Debug.Log(dropdown);
        dropdown.options.Clear();

        foreach(GameObject go in gameObjects) 
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = go.name });
        }

        dropdown.onValueChanged.AddListener(delegate { DropItemSelected(dropdown); });
        currentActive = gameObjects[0];
        currentActive.SetActive(true);
    }

    public void DropItemSelected(TMP_Dropdown dropdown) 
    {
        currentActive.SetActive(false);
        currentActive = gameObjects[dropdown.value];
        currentActive.SetActive(true);
    }
}
