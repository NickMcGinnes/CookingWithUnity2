using UnityEngine;

public class Ep04PickupDrop : MonoBehaviour
{
    public float PickupDistance = 5f;
    public float HoldDistance = 4f;
    public LayerMask PickupMask;
    private bool _isHoldingSomething = false;
    [SerializeField] private GameObject _heldObject;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDistance();
        PickupCheck();
    }


    private void ChangeDistance()
    {
        if (!_isHoldingSomething) return;

        float distMin = 1f;
        float distMax = 6f;

        float range = HoldDistance += Input.GetAxis("Mouse ScrollWheel");
        HoldDistance = Mathf.Clamp(range, distMin, distMax);
    }


    private void PickupCheck()
    {
        RaycastHit hitinfo;
        if (!_isHoldingSomething) //not holding something so try to pick up something
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(transform.position, transform.forward, out hitinfo, PickupDistance, PickupMask))
                {
                    Debug.Log("Looking at " + hitinfo.collider);
                    hitinfo.collider.transform.parent = transform.parent;
                    hitinfo.collider.GetComponent<Rigidbody>().isKinematic = true;
                    _heldObject = hitinfo.collider.gameObject;
                    _isHoldingSomething = true;
                }
            }
        }
        else //drop object
        {
            Vector3 newPosition = transform.position;
            newPosition += transform.forward * HoldDistance;
            _heldObject.transform.position = newPosition;

            if (Input.GetMouseButtonDown(0))
            {
                _heldObject.GetComponent<Rigidbody>().isKinematic = false;
                _heldObject.transform.parent = null;
                _heldObject = null;
                _isHoldingSomething = false;
            }
        }
    }
}