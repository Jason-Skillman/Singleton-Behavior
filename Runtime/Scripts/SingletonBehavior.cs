using UnityEngine;

namespace Singleton {
	public class SingletonBehavior<T> : MonoBehaviour where T : MonoBehaviour {

		public static T Instance { get; private set; }

		protected virtual void Awake() {
			if(Instance == null) Instance = this as T;
			else Destroy(gameObject);
		}

	}	
}
