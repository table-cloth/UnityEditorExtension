using UnityEngine;
using System.Collections;

public class InspectorExtendNumberSample : MonoBehaviour
{
	/// <summary>
	/// Showing seekbar in Inspector window
	/// 
	/// [NOTE]
	/// [Range(<min-value>, <max-value>)]
	/// </summary>
	[Range(-100, 100)]
	public int integerSeekbar;

	/// <summary>
	/// Showing seekbar in Inspector window
	/// 
	/// </summary>
	[Range(-50, 10)]
	public float foatSeekbar;
}
