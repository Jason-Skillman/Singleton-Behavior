using UnityEngine;

namespace Singleton {
	public class SingletonBehavior<T> : MonoBehaviour where T : MonoBehaviour {

		private static T instance;

		public static T Instance {
			get {
				if(instance == null) {
					//Try to find an existing T object in scene
					instance = FindObjectOfType<T>();
					
					//Create a new T GameObject if one does not exist
					if(instance == null) {
						GameObject emptyGameObject = new GameObject();
						emptyGameObject.name = typeof(T).ToString();
						instance = emptyGameObject.AddComponent<T>();
					}
				}
				return instance;
			}
		}

		protected virtual void Awake() {
			if(Instance == null) {
				Destroy(gameObject);
				return;
			}

			DontDestroyOnLoad(gameObject);
			
			instance = GetComponent<T>();
		}

	}	
}
