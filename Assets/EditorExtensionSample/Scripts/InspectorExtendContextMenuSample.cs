using UnityEngine;
using System.Collections;

/// <summary>
/// Sample for menu selection related extensions
/// </summary>
public class InspectorExtendContextMenuSample : MonoBehaviour {

	// Context menu item will be shown when right click "number1" in inspector
	[ContextMenuItem ("Random", "RandomNumber")]
	[ContextMenuItem ("Reset",  "ResetNumber")]
	public int number1;

	// Context menu item will NOT be shown with "number2"
	public int number2;

	/// <summary>
	/// Set random value for "number1".
	/// </summary>
	void RandomNumber()
	{
		number1 = Random.Range (0, 100);
	}

	/// <summary>
	/// Reset value for "number1"
	/// </summary>
	void ResetNumber()
	{
		number1 = 0;
	}

	/// <summary>
	/// Gets the random number.
	/// </summary>
	/// <returns>The random number.</returns>
	/// <param name="min">Minimum.</param>
	/// <param name="max">Max.</param>
	int GetRandomNumber(int min, int max)
	{
		return Random.Range (min, max);
	}
		
}
