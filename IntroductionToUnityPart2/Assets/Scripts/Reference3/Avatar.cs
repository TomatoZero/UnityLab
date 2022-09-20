using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Reference3
{
    public class Avatar : MonoBehaviour, IKillable, IDamageable<float>, IPointerClickHandler
    {
        [SerializeField] private float hp;

        private static int avatarCount;
        public static int AvatarCount { get => avatarCount; }

        private float damageTaken = 10;


        public void Start()
        {
            avatarCount++;
            Debug.Log("Create avatar #" + avatarCount);
        }

        public void Kill()
        {
            Destroy(gameObject);
            avatarCount--;
        }

        public void Damage(float damageTaken)
        {
            hp -= damageTaken;

            if (hp <= 0)
                Kill();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Damage(damageTaken);
        }
    }
}
