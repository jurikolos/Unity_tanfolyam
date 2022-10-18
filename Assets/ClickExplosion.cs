using UnityEngine;

class ClickExplosion : MonoBehaviour
{
    [SerializeField] float _maxForce;
    [SerializeField] float _range;
    [SerializeField] float _upward;

    [SerializeField] LayerMask _raycastLayers;
    [SerializeField] ParticleSystem _particleSystem;

    [SerializeField] Rigidbody[] _rigidbodies;

    Vector3 _lastRayHit;

    void Start()
    {
        _rigidbodies = FindObjectsOfType<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Camera _cam = Camera.main;

            Vector3 _mousePos = Input.mousePosition;
            Ray _ray = _cam.ScreenPointToRay(_mousePos);

            // Ray _otherRay = new Ray(transform.position, transform.forward);

            bool _doesHit = Physics.Raycast(_ray, out RaycastHit _hit, 100, _raycastLayers);

            if (_doesHit)
            {
                _lastRayHit = _hit.point;
                Debug.Log(_hit.collider.name + "   " + _hit.point);
                _particleSystem.Play();
                _ExplodeAll (_lastRayHit);
            }
        }
    }

    void _ExplodeAll (Vector3 _pos)
    {
        foreach (Rigidbody _rb in _rigidbodies)
        {
            // _ExplodeOne(_pos, _rb);
            _rb.AddExplosionForce(_maxForce, _pos, _range, _upward, ForceMode.Impulse);
        }
    }

    void _ExplodeOne (Vector3 _pos, Rigidbody _rb)
    {

        Vector3 _distanceVect = _rb.transform.position - _pos;
        float distance = _distanceVect.magnitude;
        Vector3 _direction = _distanceVect / distance;

        if (distance < _range)
        {
            float _force = _maxForce * (_range - distance) / _range;
            _rb.AddForce(_force * _direction, ForceMode.Impulse);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_lastRayHit, 0.2f);
    }
}
