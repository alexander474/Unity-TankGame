using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float Speed = 12f;                 // How fast the tank moves forward and back.
    public float TurnSpeed = 180f;            // How fast the tank turns in degrees per second.

    private string _MovementAxisName;          // The name of the input axis for moving forward and back.
    private string _TurnAxisName;              // The name of the input axis for turning.
    private Rigidbody _Rigidbody;              // Reference used to move the tank.
    private float _MovementInputValue;         // The current value of the movement input.
    private float _TurnInputValue;             // The current value of the turn input.
    private float _OriginalPitch;              // The pitch of the audio source at the start of the scene.
    private Vector3 playerCom;                 // Reset center of mass so tank no flip over


    private void Awake()
    {
        playerCom.Set(0.0f, 0.5f, 1.1f);
        _Rigidbody = GetComponent<Rigidbody>();
        _Rigidbody.centerOfMass = playerCom;
    }


    private void OnEnable()
    {
        // When the tank is turned on, make sure it's not kinematic.
        _Rigidbody.isKinematic = false;

        // Also reset the input values.
        _MovementInputValue = 0f;
        _TurnInputValue = 0f;
    }


    private void OnDisable()
    {
        // When the tank is turned off, set it to kinematic so it stops moving.
        _Rigidbody.isKinematic = true;
    }


    private void Start()
    {
        // The axes names are based on player number.
        _MovementAxisName = "Vertical";
        _TurnAxisName = "Horizontal";
    }


    private void Update()
    {
        // Store the value of both input axes.
        _MovementInputValue = Input.GetAxis(_MovementAxisName);
        _TurnInputValue = Input.GetAxis(_TurnAxisName);
    }

    private void FixedUpdate()
    {
        // Adjust the rigidbodies position and orientation in FixedUpdate.
        Move();
        Turn();
    }


    private void Move()
    {
        // Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
        Vector3 movement = transform.forward * _MovementInputValue * Speed * Time.deltaTime;

        // Apply this movement to the rigidbody's position.
        _Rigidbody.MovePosition(_Rigidbody.position + movement);
    }


    private void Turn()
    {
        // Determine the number of degrees to be turned based on the input, speed and time between frames.
        float turn = _TurnInputValue * TurnSpeed * Time.deltaTime;

        // Make this into a rotation in the y axis.
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        // Apply this rotation to the rigidbody's rotation.
        _Rigidbody.MoveRotation(_Rigidbody.rotation * turnRotation);
    }
}

// https://unity3d.com/learn/tutorials/projects/tanks-tutorial/tank-creation-control?playlist=20081