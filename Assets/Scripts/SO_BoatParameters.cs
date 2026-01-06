using UnityEngine;

[CreateAssetMenu(fileName = "SO_BoatParameters", menuName = "Scriptable Objects/SO_BoatParameters")]
public class SO_BoatParameters : ScriptableObject
{
    [SerializeField]
    private float width = 16f;

    [SerializeField]
    private float length = 9f;

    [Range(0, 300)]
    [SerializeField]
    private int SpawningCount;

    [SerializeField]
    private GameObject boatHouseA = null;

    [SerializeField]
    private GameObject boatHouseB = null;

    [SerializeField]
    private GameObject boatHouseC = null;

    [Range(0, 10)]
    public float maxSpeed = 6f;

    [Range(0.1f, 45f)]
    public float steeringSpeed = 4.5f;

    [Range(.01f, .5f)]
    public float maxForce = .03f;

    [Range(1, 10)]
    public float neighborhoodRadius = 4f;

    [Range(0.1f, 10f)]
    public float separationRadius = 2.4f;

    [Range(0, 3)]
    public float separationAmount = 1.1f;

    [Range(0, 3)]
    public float cohesionAmount = 0.3f;

    [Range(0, 3)]
    public float alignmentAmount = 0.5f;

    public float Width
    {
        get { return width; }
    }

    public float Length
    {
        get { return length; }
    }

    public int spawningCount
    {
        get { return SpawningCount; }
    }

    public GameObject BoatHouseA
    {
        get { return boatHouseA; }
    }

    public GameObject BoatHouseB
    {
        get { return boatHouseB; }
    }

    public GameObject BoatHouseC
    {
        get { return boatHouseC; }
    }

    public float MaxSpeed
    {
        get { return maxSpeed; }
    }

    public float SteeringSpeed
    {
        get { return steeringSpeed; }
    }

    public float MaxForce
    {
        get { return maxForce; }
    }

    public float NeighborhoodRadius
    {
        get { return neighborhoodRadius; }
    }

    public float SeparationRadius
    {
        get { return separationRadius; }
    }

    public float SeparationAmount
    {
        get { return separationAmount; }
    }

    public float AlignmentAmount
    {
        get { return alignmentAmount; }
    }


}
