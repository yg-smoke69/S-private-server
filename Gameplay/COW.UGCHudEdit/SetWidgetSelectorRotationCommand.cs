using GCommon.CommandPattern;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.UGCHudEdit;

[Token(Token = "0x2002409")]
public class SetWidgetSelectorRotationCommand : Command
{
	[Token(Token = "0x400E093")]
	[FieldOffset(Offset = "0x10")]
	private UIUGCHudWidgetSelectorController m_Selector;

	[Token(Token = "0x400E094")]
	[FieldOffset(Offset = "0x14")]
	private Quaternion m_LastRotation;

	[Token(Token = "0x400E095")]
	[FieldOffset(Offset = "0x24")]
	private Quaternion m_Rotation;

	[Token(Token = "0x600CBA5")]
	[Address(RVA = "0x2345404", Offset = "0x2345404", VA = "0x2345404")]
	public SetWidgetSelectorRotationCommand()
	{
	}

	[Token(Token = "0x600CBA6")]
	[Address(RVA = "0x234540C", Offset = "0x234540C", VA = "0x234540C")]
	public void Set(UIUGCHudWidgetSelectorController selector, Quaternion rotation)
	{
	}

	[Token(Token = "0x600CBA7")]
	[Address(RVA = "0x2345430", Offset = "0x2345430", VA = "0x2345430", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CBA8")]
	[Address(RVA = "0x23454E0", Offset = "0x23454E0", VA = "0x23454E0", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CBA9")]
	[Address(RVA = "0x2345538", Offset = "0x2345538", VA = "0x2345538", Slot = "16")]
	public override void Clear()
	{
	}
}
