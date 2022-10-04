using UnityEngine;

public class Move : MonoBehaviour {

    [SerializeField] private Vector3 goal = new Vector3(5, 0, 4);
    [SerializeField] private float speed = 1f;

    void Start() {

    }

    void LateUpdate() 
    {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}
