using UnityEngine;
using System.Collections;

/// <summary>
/// Sample class of loading data from ScriptableObject instance
/// </summary>
public class GlobalVariablesUsageSample : MonoBehaviour {

	/// <summary>
	/// Loads the gloabal variable.
	/// </summary>
	private GlobalVariables.Variables LoadVariables()
	{
		GlobalVariables globalVariables =
			Resources.Load(GlobalVariables.CLASS_NAME) as GlobalVariables;
		return globalVariables.variables;
	}

	/// <summary>
	/// Sample of using global variable
	/// 
	/// [NOTE]
	/// values of data loaded MUST NOT be overwritten
	/// since it will affect all other class using same values
	/// </summary>
	private void GetVariableSample()
	{
		GlobalVariables.Variables variables = LoadVariables ();
		int value = variables.numberA;
		value = variables.numberB;
		string text = variables.textAreaA;

		// use variable just to remove warning log
		value += 0;
		text += "";
	}
}
