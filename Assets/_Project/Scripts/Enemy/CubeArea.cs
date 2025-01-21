using UnityEngine;
  
public class CubeArea : MonoBehaviour
{
	[SerializeField] private Vector3 area;

	public Vector3 GetRandomInsideZone()
	{
		Vector3 result = transform.position;

		result.x += Random.Range(-area.x / 2, area.x / 2);
		result.y += Random.Range(-area.y / 2, area.y / 2);
		result.z += Random.Range(-area.z / 2, area.z / 2);

		return result;
	}


#if UNITY_EDITOR
	private void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube(transform.position, area);
	}
#endif
}
