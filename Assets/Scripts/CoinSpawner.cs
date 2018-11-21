using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
	[SerializeField] private GameObject _coinPrefab;
	[SerializeField] [Range(0f, 4f)] private float _spawnRange = 4;
	void Start ()
	{
		this.UpdateAsObservable()
			.Where(_ => Input.GetButtonDown("Fire1"))
			.Subscribe(_ => { Instantiate(_coinPrefab, GetRandomSpawnPos(), Quaternion.identity); });
	}

	private Vector3 GetRandomSpawnPos()
	{
		return transform.position + new Vector3(Random.Range(-_spawnRange, _spawnRange), 0, 0);
	}
}
