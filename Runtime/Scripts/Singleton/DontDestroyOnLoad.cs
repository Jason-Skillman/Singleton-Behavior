namespace JasonSkillman.Singleton {
	using UnityEngine;

	public class DontDestroyOnLoad : MonoBehaviour {
		private void Start() => DontDestroyOnLoad(gameObject);
	}
}
