using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    void Start()
    {
        Fruit MyFruit = new Apple();

        MyFruit.SayHello();
        MyFruit.Chop();


        Apple myApple = (Apple)MyFruit;

        myApple.SayHello();
        myApple.Chop();
    }
}
