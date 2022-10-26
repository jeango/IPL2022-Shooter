
using System;
using Ipl2022;
using UnityEngine;
using Random = UnityEngine.Random;

public class AreaSpawner : MonoBehaviour, ISpawner
{
    [SerializeField] private Rect _dimensions;
    [SerializeField] private GameObject _spawnedObject;

    public Action<GameObject> Spawned { get; set; }
    public GameObject Spawn()
    {
        var spawnPos = new Vector2();
        spawnPos.x = Random.Range(0, _dimensions.width) + _dimensions.x;
        spawnPos.y = Random.Range(0, _dimensions.height) + _dimensions.y;
        return Instantiate(_spawnedObject, spawnPos, Quaternion.identity);
    }

    public void OnValidate()
    {
        var newPos = transform.position;
        newPos.x = _dimensions.x;
        newPos.y = _dimensions.y;
        transform.position = newPos;
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(new Vector2(_dimensions.x, _dimensions.y), new Vector2(_dimensions.width, _dimensions.height));
    }
}
