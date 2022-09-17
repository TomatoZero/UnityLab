using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Reference3
{
    public class Avatar : MonoBehaviour, IKillable, IDamageable<float>, IPointerClickHandler
    {
        [SerializeField] private bool IfKillTrue;
        [SerializeField] private float damageTaken;
        [SerializeField] private float hp;
        [SerializeField] private Color targetColor;

        private static int avatarCount;
        private SpriteRenderer target;
        public static int AvatarCount { get => avatarCount; }

        public void Start()
        {
            avatarCount++;
            Debug.Log("Create avatar #" + avatarCount);

            target = GetComponent<SpriteRenderer>();
            normalize = (hp / damageTaken) / 100;
        }

        public void Kill()
        {
            Destroy(gameObject);
            avatarCount--;
        }

        private float normalize;
        public void Damage(float damageTaken)
        {
            hp -= damageTaken;

            target.color = Color.Lerp(target.color, targetColor, normalize);
            normalize += normalize;

            if (hp <= 0)
            {
                Destroy(gameObject);
                avatarCount--;
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (IfKillTrue)
                Kill();
            else
                Damage(damageTaken);
        }
    }
}
