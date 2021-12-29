namespace Singleton {
	using UnityEngine;

	public class SingletonBehaviorPersistant<T> : MonoBehaviour where T : MonoBehaviour {
		
		public static T Instance { get; private set; }

		protected virtual void Awake() {
			if(Instance != null) {
				Destroy(gameObject);
				return;
			}
			
			Instance = this as T;
			DontDestroyOnLoad(gameObject);
		}
	}
}