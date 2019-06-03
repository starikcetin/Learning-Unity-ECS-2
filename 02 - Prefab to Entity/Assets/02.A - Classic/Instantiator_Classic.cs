using UnityEngine;

public class Instantiator_Classic : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    private void Start()
    {
	    // instantiate the prefab as a GameObject...
		Instantiate(_prefab, Vector3.zero, Quaternion.identity);

		// ...then the ConvertToEntity on the it does its magic.
    }
}
