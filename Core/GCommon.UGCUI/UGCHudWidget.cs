using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.UGCUI;

[Token(Token = "0x200410B")]
public class UGCHudWidget : UGCUIWidget
{
	[Token(Token = "0x200410C")]
	public enum HorizontalAlignmentEnum
	{
		[Token(Token = "0x401B523")]
		Left,
		[Token(Token = "0x401B524")]
		Center,
		[Token(Token = "0x401B525")]
		Right
	}

	[Token(Token = "0x200410D")]
	public enum VerticalAlignmentEnum
	{
		[Token(Token = "0x401B527")]
		Top,
		[Token(Token = "0x401B528")]
		Center,
		[Token(Token = "0x401B529")]
		Bottom
	}

	[Token(Token = "0x401B51C")]
	[FieldOffset(Offset = "0x40")]
	public Action<HorizontalAlignmentEnum> onHorizontalAlignmentChangedAction;

	[Token(Token = "0x401B51D")]
	[FieldOffset(Offset = "0x44")]
	public Action<VerticalAlignmentEnum> onVerticalAlignmentChangedAction;

	[Token(Token = "0x401B51E")]
	[FieldOffset(Offset = "0x48")]
	private HorizontalAlignmentEnum m_HorizontalAlignment;

	[Token(Token = "0x401B51F")]
	[FieldOffset(Offset = "0x4C")]
	private VerticalAlignmentEnum m_VerticalAlignment;

	[Token(Token = "0x401B520")]
	[FieldOffset(Offset = "0x50")]
	private Pivot m_AlignmentPivot;

	[Token(Token = "0x401B521")]
	[FieldOffset(Offset = "0x54")]
	private bool m_CustomAdapt;

	[Token(Token = "0x17001D3B")]
	public bool ColliderEnabled
	{
		[Token(Token = "0x601A8FE")]
		[Address(RVA = "0x324DB78", Offset = "0x324DB78", VA = "0x324DB78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A8FF")]
		[Address(RVA = "0x324DCC4", Offset = "0x324DCC4", VA = "0x324DCC4")]
		set
		{
		}
	}

	[Token(Token = "0x17001D3C")]
	public UGCHudWidget ParentWidget
	{
		[Token(Token = "0x601A900")]
		[Address(RVA = "0x324DE14", Offset = "0x324DE14", VA = "0x324DE14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D3D")]
	public HorizontalAlignmentEnum AlignmentHorizontal
	{
		[Token(Token = "0x601A901")]
		[Address(RVA = "0x324DF08", Offset = "0x324DF08", VA = "0x324DF08")]
		get
		{
			return default(HorizontalAlignmentEnum);
		}
		[Token(Token = "0x601A902")]
		[Address(RVA = "0x324DF10", Offset = "0x324DF10", VA = "0x324DF10")]
		set
		{
		}
	}

	[Token(Token = "0x17001D3E")]
	public VerticalAlignmentEnum AlignmentVertical
	{
		[Token(Token = "0x601A903")]
		[Address(RVA = "0x324E0FC", Offset = "0x324E0FC", VA = "0x324E0FC")]
		get
		{
			return default(VerticalAlignmentEnum);
		}
		[Token(Token = "0x601A904")]
		[Address(RVA = "0x324E104", Offset = "0x324E104", VA = "0x324E104")]
		set
		{
		}
	}

	[Token(Token = "0x17001D3F")]
	public Vector2 AlignmentPivotOffset
	{
		[Token(Token = "0x601A905")]
		[Address(RVA = "0x324E1F0", Offset = "0x324E1F0", VA = "0x324E1F0")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001D40")]
	public float LocalEulerAngleZ
	{
		[Token(Token = "0x601A906")]
		[Address(RVA = "0x324E208", Offset = "0x324E208", VA = "0x324E208")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601A907")]
		[Address(RVA = "0x324E24C", Offset = "0x324E24C", VA = "0x324E24C")]
		set
		{
		}
	}

	[Token(Token = "0x17001D41")]
	public bool CustomAdapt
	{
		[Token(Token = "0x601A908")]
		[Address(RVA = "0x324DAC0", Offset = "0x324DAC0", VA = "0x324DAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A909")]
		[Address(RVA = "0x324E2E8", Offset = "0x324E2E8", VA = "0x324E2E8")]
		set
		{
		}
	}

	[Token(Token = "0x17001D42")]
	public bool IsFirstChild
	{
		[Token(Token = "0x601A90A")]
		[Address(RVA = "0x324E300", Offset = "0x324E300", VA = "0x324E300")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601A8FC")]
	[Address(RVA = "0x324D07C", Offset = "0x324D07C", VA = "0x324D07C")]
	public UGCHudWidget()
	{
	}

	[Token(Token = "0x601A8FD")]
	[Address(RVA = "0x324DB70", Offset = "0x324DB70", VA = "0x324DB70", Slot = "9")]
	public virtual UGCHudWidgetType GetHudWidgetType()
	{
		return default(UGCHudWidgetType);
	}

	[Token(Token = "0x601A90B")]
	[Address(RVA = "0x324DF48", Offset = "0x324DF48", VA = "0x324DF48")]
	private void UpdateAnchor()
	{
	}

	[Token(Token = "0x601A90C")]
	[Address(RVA = "0x324E028", Offset = "0x324E028", VA = "0x324E028")]
	private void UpdateAlignmentPivot()
	{
	}

	[Token(Token = "0x601A90D")]
	[Address(RVA = "0x324E048", Offset = "0x324E048", VA = "0x324E048")]
	private void SetHorizontalAlignmentDirty()
	{
	}

	[Token(Token = "0x601A90E")]
	[Address(RVA = "0x324E13C", Offset = "0x324E13C", VA = "0x324E13C")]
	private void SetVerticalAlignmentDirty()
	{
	}

	[Token(Token = "0x601A90F")]
	[Address(RVA = "0x324E394", Offset = "0x324E394", VA = "0x324E394", Slot = "5")]
	protected override void OnInternalDestroy()
	{
	}
}
