using UnityEngine;
using System.Collections;

/// <summary>
/// Sample for visualizing inspector to be seen easier
/// In Inspector view, all variables will be listed in order we declare fields
/// </summary>
public class InspectorExtendVisualize : MonoBehaviour {

	/// <summary>
	/// Puts header line in inspector
	/// Empty line is automatically inserted above if needed
	/// </summary>
	[Header("Header 1")]

	public int valueA = 0;
	public string valueB = "valueB";

	/// <summary>
	/// Puts header line in inspector
	/// </summary>
	[Header("Header 2")]

	public Color valueC;
	public float valueD = 0.5f;

}
