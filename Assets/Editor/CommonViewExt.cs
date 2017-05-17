using UnityEditor;
using UnityEngine;

/// <summary>
/// Common view extensions for Hierarchy & Project
/// </summary>
public abstract class CommonViewExt {

	// const color
	protected static readonly Color EXTENSION_TEXT_COLOR = new Color (1.0f, 1.0f, 1.0f, 0.75f); 
	protected static readonly Color ALERT_WARNING_TEXT_COLOR = new Color (0.0f, 0.0f, 0.0f, 0.75f); 
    protected static readonly Color ODD_LINE_BG_COLOR = new Color (1.0f, 1.0f, 1.0f, 1.0f);
    protected static readonly Color EVEN_LINE_BG_COLOR = new Color (1.0f, 1.0f, 1.0f, 0.5f);
	protected static readonly Color COMPONENT_COLOR_DISABLED = new Color(1.0f, 1.0f, 1.0f, 0.25f);
	protected static readonly Color COMPONENT_COLOR_ENABLED = new Color(1.0f, 1.0f, 1.0f, 1.0f);

	// const size
	protected static readonly int ALERT_WARNING_MARGIN_LEFT = 4;
	protected static readonly int ALERT_WARNING_WIDTH = 16;
	protected static readonly int COMPONENT_ICON_WIDTH = 16;
	protected static readonly int COMPONENT_ICON_HEIGHT = 16;

	// const text
	protected static readonly string ALERT_WARNING_TEXT = "x";
	protected static readonly string KEY_ENABLED = "enabled";

	/// <summary>
	/// Initialize this instance.
	/// </summary>
	[InitializeOnLoadMethod]
	public static void Initialize ()
	{
		// Write OnGUI methods for each sub-class
	}

	/// <summary>
	/// Switchs the color per line.
	/// </summary>
	/// <param name="selectionRect">Selection rect.</param>
	protected static void SwitchColorPerLine(Rect selectionRect)
	{
		int index = (int)(selectionRect.y - 4) / 16;
		// only change color if odd line number
        Color lineColor = index % 2 == 0
            ? EVEN_LINE_BG_COLOR
            : ODD_LINE_BG_COLOR;

		Rect pos = selectionRect;
		pos.x = 0;
		pos.xMax = selectionRect.xMax;

		Color color = GUI.color;
        GUI.color = lineColor;
		GUI.Box (pos, string.Empty);
		GUI.color = color;

	}
}
