using UnityEngine;

namespace Singleton {
	public class SingletonBehavior<T> : MonoBehaviour where T : MonoBehaviour {
		
		[SerializeField]
		private bool dontDestroyOnLoad = default;
		
		private static bool isQuitting;

		private static T instance;

		public static T Instance {
			get {
				if(isQuitting) return null;
				if(instance == null) {
					//Create a new T GameObject if one does not exist
					if(instance == null) {
						GameObject emptyObject = new GameObject();
						emptyObject.name = typeof(T).ToString();
						instance = emptyObject.AddComponent<T>();
					}
				}
				return instance;
			}
		}

		protected virtual void Awake() {
			if(instance == null) {
				instance = FindObjectOfType<T>();
			} else {
				Destroy(gameObject);
				return;
			}

			if(dontDestroyOnLoad)
				DontDestroyOnLoad(gameObject);
		}

		protected virtual void OnApplicationQuit() {
			isQuitting = true;
		}

	}	
}
