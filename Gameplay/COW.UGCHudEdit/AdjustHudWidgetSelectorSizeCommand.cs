using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.UGCHudEdit;

[Token(Token = "0x20023FE")]
public class AdjustHudWidgetSelectorSizeCommand : RecordCommand
{
	[Token(Token = "0x400E068")]
	[FieldOffset(Offset = "0x10")]
	private UIUGCHudWidgetSelectorController m_Selector;

	[Token(Token = "0x400E069")]
	[FieldOffset(Offset = "0x14")]
	private Pivot m_PivotType;

	[Token(Token = "0x400E06A")]
	[FieldOffset(Offset = "0x18")]
	private UGCHudWidget m_BindWidget;

	[Token(Token = "0x400E06B")]
	[FieldOffset(Offset = "0x1C")]
	private int m_InitWidth;

	[Token(Token = "0x400E06C")]
	[FieldOffset(Offset = "0x20")]
	private int m_InitHeight;

	[Token(Token = "0x400E06D")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_InitPosition;

	[Token(Token = "0x400E06E")]
	[FieldOffset(Offset = "0x30")]
	private int m_CurrentWidth;

	[Token(Token = "0x400E06F")]
	[FieldOffset(Offset = "0x34")]
	private int m_CurrentHeight;

	[Token(Token = "0x400E070")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_CurrentPosition;

	[Token(Token = "0x600CB66")]
	[Address(RVA = "0x2342F00", Offset = "0x2342F00", VA = "0x2342F00")]
	public AdjustHudWidgetSelectorSizeCommand()
	{
	}

	[Token(Token = "0x600CB67")]
	[Address(RVA = "0x2342FA4", Offset = "0x2342FA4", VA = "0x2342FA4")]
	public void Set(UIUGCHudWidgetSelectorController selector, Pivot pivotType)
	{
	}

	[Token(Token = "0x600CB68")]
	[Address(RVA = "0x2343084", Offset = "0x2343084", VA = "0x2343084")]
	public bool CheckCondition(Pivot pointType)
	{
		return default(bool);
	}

	[Token(Token = "0x600CB69")]
	[Address(RVA = "0x2343098", Offset = "0x2343098", VA = "0x2343098", Slot = "17")]
	public override void Record()
	{
	}

	[Token(Token = "0x600CB6A")]
	[Address(RVA = "0x2343148", Offset = "0x2343148", VA = "0x2343148", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB6B")]
	[Address(RVA = "0x234331C", Offset = "0x234331C", VA = "0x234331C", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB6C")]
	[Address(RVA = "0x23434B0", Offset = "0x23434B0", VA = "0x23434B0", Slot = "16")]
	public override void Clear()
	{
	}

	[Token(Token = "0x600CB6D")]
	[Address(RVA = "0x23432DC", Offset = "0x23432DC", VA = "0x23432DC")]
	private void GetSign(Pivot pivot, out int signX, out int signY)
	{
	}
}
