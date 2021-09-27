namespace Singleton {
	using UnityEngine;

	/// <summary>
	/// Instantiates a new GameObject with script of type <see cref="T"/> if one does not exist yet.
	/// Similar to <see cref="SingletonBehavior{T}"/>.
	/// </summary>
	public class NewSingletonBehavior<T> : MonoBehaviour where T : MonoBehaviour {
		
		[SerializeField]
		private bool dontDestroyOnLoad = default;
		
		private static bool isQuitting;

		private static T instance;

		public static T Instance {
			get {
				if(isQuitting) return null;

				//Create a new T GameObject if one does not exist
				if(instance == null) {
					GameObject emptyObject = new GameObject { name = typeof(T).ToString() };
					instance = emptyObject.AddComponent<T>();
				}
				
				return instance;
			}
		}

		protected virtual void Awake() {
			if(instance == null)
				instance = FindObjectOfType<T>();
			else {
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
