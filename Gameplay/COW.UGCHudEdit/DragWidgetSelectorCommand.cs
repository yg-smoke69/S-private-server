using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.UGCHudEdit;

[Token(Token = "0x2002400")]
public class DragWidgetSelectorCommand : RecordCommand
{
	[Token(Token = "0x400E073")]
	[FieldOffset(Offset = "0x10")]
	private UIUGCHudWidgetSelectorController m_Selector;

	[Token(Token = "0x400E074")]
	[FieldOffset(Offset = "0x14")]
	private UGCHudWidget m_BindWidget;

	[Token(Token = "0x400E075")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 m_StartPosition;

	[Token(Token = "0x400E076")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_EndPosition;

	[Token(Token = "0x600CB73")]
	[Address(RVA = "0x2343950", Offset = "0x2343950", VA = "0x2343950")]
	public DragWidgetSelectorCommand()
	{
	}

	[Token(Token = "0x600CB74")]
	[Address(RVA = "0x2343968", Offset = "0x2343968", VA = "0x2343968")]
	public void Set(UIUGCHudWidgetSelectorController selector)
	{
	}

	[Token(Token = "0x600CB75")]
	[Address(RVA = "0x23439F8", Offset = "0x23439F8", VA = "0x23439F8")]
	public bool CheckCondition()
	{
		return default(bool);
	}

	[Token(Token = "0x600CB76")]
	[Address(RVA = "0x2343A84", Offset = "0x2343A84", VA = "0x2343A84", Slot = "17")]
	public override void Record()
	{
	}

	[Token(Token = "0x600CB77")]
	[Address(RVA = "0x2343AEC", Offset = "0x2343AEC", VA = "0x2343AEC", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB78")]
	[Address(RVA = "0x2343BC4", Offset = "0x2343BC4", VA = "0x2343BC4", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB79")]
	[Address(RVA = "0x2343C98", Offset = "0x2343C98", VA = "0x2343C98", Slot = "16")]
	public override void Clear()
	{
	}
}
