using UnityEngine;

namespace JasonSkillman.Singleton
{
	public class DontDestroyOnLoad : MonoBehaviour
	{
		private void Start() => DontDestroyOnLoad(gameObject);
	}
}
