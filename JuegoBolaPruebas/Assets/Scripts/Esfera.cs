using UnityEngine;
using UnityEngine.InputSystem;

public class Esfera : MonoBehaviour
{
    public Rigidbody rb;
    public Vector2 teclaXY;
   
    private float movimientoX;
    private float movimientoY;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnMove(InputValue teclasPulsadas) {

        teclaXY = teclasPulsadas.Get<Vector2>();

        Debug.Log(teclaXY.x + " " + teclaXY.y);

    }

    private void FixedUpdate()
    {
        Vector3 movimiento = new Vector3(teclaXY.x, 0, teclaXY.y);
        rb.linearVelocity = movimiento * 5;
    }
}
