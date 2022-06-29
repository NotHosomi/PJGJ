using UnityEngine;

public class Wire : MonoBehaviour {

    public Rigidbody2D hook;

    public GameObject wirePrefab;

    public int wires = 7;

    void Start() {
        GenerateWire();
    }

    void GenerateWire() {
        Rigidbody2D previousRB = hook;
        for (int i = 0; i < wires; i++) {
            GameObject link = Instantiate(wirePrefab, transform);
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousRB;

            previousRB = link.GetComponent<Rigidbody2D>();
        }
    }
}
