using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference3 {
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private int minAvatarCount;
        [SerializeField] private GameObject SpawnObject;
        [SerializeField] private GameObject Shield;

        void Start()
        {
            for (int i = 0; i < minAvatarCount; i++)
            {
                RandomSpawn();
            }
        }

        void Update()
        {
            if (Avatar.AvatarCount < minAvatarCount)
            {
                RandomSpawn();
            }
        }

        private void RandomSpawn()
        {
            Vector2 pos = new Vector2(transform.position.x + Random.Range(-12, 12), transform.position.y + Random.Range(-4, 4));
            GameObject enemy = Instantiate(SpawnObject, pos, Quaternion.identity);

            if (Random.Range(0f, 1f) <= 0.2)
            {
                GameObject sheild = Instantiate(Shield, pos, Quaternion.identity);
                sheild.transform.parent = enemy.transform;
            }
        }
    }
}
