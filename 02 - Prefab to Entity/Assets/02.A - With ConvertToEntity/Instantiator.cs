using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
	
    void Start()
    {
		Instantiate(_prefab, Vector3.zero, Quaternion.identity);
    }
}
