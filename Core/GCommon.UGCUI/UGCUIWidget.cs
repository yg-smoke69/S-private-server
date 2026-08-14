using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.UGCUI;

[Token(Token = "0x2004105")]
public abstract class UGCUIWidget : UGCUIBehaviour
{
	[Token(Token = "0x2004106")]
	public enum AnchorType
	{
		[Token(Token = "0x401B509")]
		TopLeft,
		[Token(Token = "0x401B50A")]
		Top,
		[Token(Token = "0x401B50B")]
		TopRight,
		[Token(Token = "0x401B50C")]
		Left,
		[Token(Token = "0x401B50D")]
		Center,
		[Token(Token = "0x401B50E")]
		Right,
		[Token(Token = "0x401B50F")]
		BottomLeft,
		[Token(Token = "0x401B510")]
		Bottom,
		[Token(Token = "0x401B511")]
		BottomRight
	}

	[Token(Token = "0x401B4FE")]
	[FieldOffset(Offset = "0x0")]
	protected static readonly Vector2 Vec2Half;

	[Token(Token = "0x401B4FF")]
	[FieldOffset(Offset = "0x18")]
	protected AnchorType m_Anchor;

	[Token(Token = "0x401B500")]
	[FieldOffset(Offset = "0x1C")]
	protected Vector2 m_AnchorOffset;

	[Token(Token = "0x401B501")]
	[FieldOffset(Offset = "0x24")]
	protected Vector2 m_AnchorPosition;

	[Token(Token = "0x401B502")]
	[FieldOffset(Offset = "0x2C")]
	protected UIWidget m_Widget;

	[Token(Token = "0x401B503")]
	[FieldOffset(Offset = "0x30")]
	public Action onNameChanged;

	[Token(Token = "0x401B504")]
	[FieldOffset(Offset = "0x34")]
	public Action onSizeChanged;

	[Token(Token = "0x401B505")]
	[FieldOffset(Offset = "0x38")]
	public Action onPositionChanged;

	[Token(Token = "0x401B506")]
	[FieldOffset(Offset = "0x3C")]
	public Action onRotationChanged;

	[Token(Token = "0x401B507")]
	[FieldOffset(Offset = "0x8")]
	private static Func<UGCUIWidget, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001D28")]
	public UIWidget Widget
	{
		[Token(Token = "0x601A8CF")]
		[Address(RVA = "0x2C9077C", Offset = "0x2C9077C", VA = "0x2C9077C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D29")]
	public string Name
	{
		[Token(Token = "0x601A8D0")]
		[Address(RVA = "0x2C9084C", Offset = "0x2C9084C", VA = "0x2C9084C")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A8D1")]
		[Address(RVA = "0x2C90854", Offset = "0x2C90854", VA = "0x2C90854")]
		set
		{
		}
	}

	[Token(Token = "0x17001D2A")]
	public int Width
	{
		[Token(Token = "0x601A8D2")]
		[Address(RVA = "0x2C8F9E8", Offset = "0x2C8F9E8", VA = "0x2C8F9E8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601A8D3")]
		[Address(RVA = "0x2C9091C", Offset = "0x2C9091C", VA = "0x2C9091C")]
		set
		{
		}
	}

	[Token(Token = "0x17001D2B")]
	public int Height
	{
		[Token(Token = "0x601A8D4")]
		[Address(RVA = "0x2C8FA18", Offset = "0x2C8FA18", VA = "0x2C8FA18")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601A8D5")]
		[Address(RVA = "0x2C909A0", Offset = "0x2C909A0", VA = "0x2C909A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D2C")]
	public Vector3 Position
	{
		[Token(Token = "0x601A8D6")]
		[Address(RVA = "0x2C90A24", Offset = "0x2C90A24", VA = "0x2C90A24")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x601A8D7")]
		[Address(RVA = "0x2C90A64", Offset = "0x2C90A64", VA = "0x2C90A64")]
		set
		{
		}
	}

	[Token(Token = "0x17001D2D")]
	public Vector3 LocalPosition
	{
		[Token(Token = "0x601A8D8")]
		[Address(RVA = "0x2C90AD4", Offset = "0x2C90AD4", VA = "0x2C90AD4")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x601A8D9")]
		[Address(RVA = "0x2C90B14", Offset = "0x2C90B14", VA = "0x2C90B14")]
		set
		{
		}
	}

	[Token(Token = "0x17001D2E")]
	public int Depth
	{
		[Token(Token = "0x601A8DA")]
		[Address(RVA = "0x2C8F530", Offset = "0x2C8F530", VA = "0x2C8F530")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001D2F")]
	public Vector2 Size
	{
		[Token(Token = "0x601A8DB")]
		[Address(RVA = "0x2C90B84", Offset = "0x2C90B84", VA = "0x2C90B84")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
		[Token(Token = "0x601A8DC")]
		[Address(RVA = "0x2C90BDC", Offset = "0x2C90BDC", VA = "0x2C90BDC")]
		set
		{
		}
	}

	[Token(Token = "0x17001D30")]
	public Vector2 Pivot
	{
		[Token(Token = "0x601A8DD")]
		[Address(RVA = "0x2C90D0C", Offset = "0x2C90D0C", VA = "0x2C90D0C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001D31")]
	public Vector3 WorldCenter
	{
		[Token(Token = "0x601A8DE")]
		[Address(RVA = "0x2C90D48", Offset = "0x2C90D48", VA = "0x2C90D48")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x17001D32")]
	public Rect Rect
	{
		[Token(Token = "0x601A8DF")]
		[Address(RVA = "0x2C90D84", Offset = "0x2C90D84", VA = "0x2C90D84")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Rect);
		}
	}

	[Token(Token = "0x17001D33")]
	public AnchorType Anchor
	{
		[Token(Token = "0x601A8E0")]
		[Address(RVA = "0x2C90E80", Offset = "0x2C90E80", VA = "0x2C90E80")]
		get
		{
			return default(AnchorType);
		}
		[Token(Token = "0x601A8E1")]
		[Address(RVA = "0x2C90E88", Offset = "0x2C90E88", VA = "0x2C90E88")]
		set
		{
		}
	}

	[Token(Token = "0x17001D34")]
	public Vector2 AnchorOffset
	{
		[Token(Token = "0x601A8E2")]
		[Address(RVA = "0x2C90F9C", Offset = "0x2C90F9C", VA = "0x2C90F9C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001D35")]
	public Vector2 AnchorPosition
	{
		[Token(Token = "0x601A8E3")]
		[Address(RVA = "0x2C90FB0", Offset = "0x2C90FB0", VA = "0x2C90FB0")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
		[Token(Token = "0x601A8E4")]
		[Address(RVA = "0x2C912B8", Offset = "0x2C912B8", VA = "0x2C912B8")]
		set
		{
		}
	}

	[Token(Token = "0x17001D36")]
	public Quaternion Rotation
	{
		[Token(Token = "0x601A8E5")]
		[Address(RVA = "0x2C915D4", Offset = "0x2C915D4", VA = "0x2C915D4")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
		[Token(Token = "0x601A8E6")]
		[Address(RVA = "0x2C91614", Offset = "0x2C91614", VA = "0x2C91614")]
		set
		{
		}
	}

	[Token(Token = "0x601A8CE")]
	[Address(RVA = "0x2C906A0", Offset = "0x2C906A0", VA = "0x2C906A0")]
	protected UGCUIWidget()
	{
	}

	[Token(Token = "0x601A8E7")]
	[Address(RVA = "0x2C91690", Offset = "0x2C91690", VA = "0x2C91690")]
	public Vector2 GetParentSize()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x601A8E8")]
	[Address(RVA = "0x2C90FE8", Offset = "0x2C90FE8", VA = "0x2C90FE8")]
	public Vector2 GetAnchorPosition(Vector2 pivot)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x601A8E9")]
	[Address(RVA = "0x2C91304", Offset = "0x2C91304", VA = "0x2C91304")]
	public void SetAnchorPosition(Vector2 pivot, Vector2 newAnchorPosition)
	{
	}

	[Token(Token = "0x601A8EA")]
	[Address(RVA = "0x2C91880", Offset = "0x2C91880", VA = "0x2C91880")]
	public void UpdateUGCUIAnchors()
	{
	}

	[Token(Token = "0x601A8EB")]
	[Address(RVA = "0x2C918C0", Offset = "0x2C918C0", VA = "0x2C918C0", Slot = "6")]
	public virtual void MarkNameChanged()
	{
	}

	[Token(Token = "0x601A8EC")]
	[Address(RVA = "0x2C918D4", Offset = "0x2C918D4", VA = "0x2C918D4", Slot = "7")]
	public virtual void MarkSizeChanged()
	{
	}

	[Token(Token = "0x601A8ED")]
	[Address(RVA = "0x2C918E8", Offset = "0x2C918E8", VA = "0x2C918E8", Slot = "8")]
	public virtual void MarkPositionChanged()
	{
	}

	[Token(Token = "0x601A8EE")]
	[Address(RVA = "0x2C91BF8", Offset = "0x2C91BF8", VA = "0x2C91BF8", Slot = "5")]
	protected override void OnInternalDestroy()
	{
	}

	[Token(Token = "0x601A8EF")]
	[Address(RVA = "0x2C91A90", Offset = "0x2C91A90", VA = "0x2C91A90")]
	protected void ForEachChildren(Func<UGCUIWidget, bool> callback)
	{
	}

	[Token(Token = "0x601A8F1")]
	[Address(RVA = "0x2C91C9C", Offset = "0x2C91C9C", VA = "0x2C91C9C")]
	private static bool _003CMarkPositionChanged_003Em__0(UGCUIWidget child)
	{
		return default(bool);
	}
}
