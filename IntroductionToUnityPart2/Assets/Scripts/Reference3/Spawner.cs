using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference3 {
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private int minAvatarCount;
        [SerializeField] private GameObject SpawnObject;

        void Start()
        {
            for (int i = 0; i < minAvatarCount; i++)
            {
                RandomSpawn();
            }
        }

        void Update()
        {
            if (Avatar.AvatarCount != minAvatarCount)
            {
                RandomSpawn();
            }
        }

        private void RandomSpawn()
        {
            Vector2 pos = new Vector2(transform.position.x + Random.Range(-13, 13), transform.position.y + Random.Range(-5, 5));
            Instantiate(SpawnObject, pos, Quaternion.identity);
        }
    }
}
