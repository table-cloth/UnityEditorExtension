using UnityEngine;
using UnityEditor;

/// <summary>
/// Class for managing Global variables.
/// By using ScriptableObject, all variable will be able to be viewed in Inspector,
/// even when the Scriptable object is in Project, and not Hierarchy.
/// </summary>
[CreateAssetMenu]
public class GlobalVariables : ScriptableObject
{
	public const string CLASS_NAME = "GlobalVariables";
	private const string MENU_PARENT = "CustomMenu";
	private const string FOLDER_NAME = "ScriptableObject";
	private const string FILE_NAME = "GlobalVariables.asset";

	// instance for accessing variables
	public Variables variables;

	/// <summary>
	/// Creates the asset file for managing Global Variables
	/// </summary>
	[MenuItem(MENU_PARENT + "/Create Scriptable Object 4 Global Variables", false, 1)]
	static void CreateGlovalVariablesAsset()
	{
		GlobalVariables instance = CreateInstance<GlobalVariables> ();

		// Create folder if not exist
		AssetDatabase.CreateFolder ("Assets", FOLDER_NAME);

		// Create ScriptableObject instance
		AssetDatabase.CreateAsset (instance, "Assets/" + FOLDER_NAME + "/" + FILE_NAME);

		// Update AssetDatabase
		AssetDatabase.Refresh ();
	}

	/// <summary>
	/// Declare values as SerializeField, so can be seen in Inspecter
	/// 
	/// All the variables declared here, can be checked
	/// & edited in "Assets/ScriptableObject/GlobalVariables.asset"
	/// 
	/// These variable
	/// </summary>
	[System.Serializable]
	public class Variables {
		public int numberA;

		public int numberB = 2;

		[TextArea(1, 5)]
		public string textAreaA = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
	}

}
