using UnityEngine;
using System.Collections;

public class InspectorExtendColorSample : MonoBehaviour
{
	[ColorUsage(false)]
	public Color rgbColor;

	[ColorUsage(true)]
	public Color rgbaColor;

	[ColorUsage(true, false, 0.0f, 8.0f, 0.125f, 3.0f)]
	public Color fullColor;
}
