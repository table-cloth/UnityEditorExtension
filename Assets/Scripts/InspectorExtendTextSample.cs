using UnityEngine;
using System.Collections;

public class InspectorExtendTextSample : MonoBehaviour
{
	private const string longTextSample = "This is sample of some random long text. This does not have any meaning, but is needed to see textArea and multiLine in the inspector view. But actually, I have no I idea of what to write, so I will fill in some random stuff only. Sorry for the people who has read all this, this has no meaning at all.";

	/// <summary>
	/// Showing texts in multi-line format
	/// 
	/// [TIPS]
	/// Multiline does not wrap text, it will be shown in 1 line
	/// 
	/// [NOTE]
	/// [Multiline(<number-of-lines-for-text-area)]
	/// </summary>
	[Multiline(3)]
	public string multiline = longTextSample;

	/// <summary>
	/// Showing texts in text-area format
	/// 
	/// [TIPS]
	/// TextArea wraps texts, and shows scrollbar if needed
	/// Usually more useful than Multiline
	/// 
	/// [NOTE]
	/// [TextArea(<min-line, <max-line>)]
	/// </summary>
	[TextArea(1, 3)]
	public string textArea = longTextSample;
}
