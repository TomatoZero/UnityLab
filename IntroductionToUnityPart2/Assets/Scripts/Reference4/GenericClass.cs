using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass<T>
{
    T item;

    public GenericClass()
    {
        Debug.Log("New genericClass create. Type: " + item.GetType());
    }

    public void UpdateItem(T newItem)
    {
        item = newItem;
        Debug.Log("Ubdate item. New value:" + newItem.ToString());
    }
}
