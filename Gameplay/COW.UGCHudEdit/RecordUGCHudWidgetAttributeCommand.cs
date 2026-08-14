using GCommon.CommandPattern;
using Il2CppDummyDll;

namespace COW.UGCHudEdit;

[Token(Token = "0x2002402")]
public class RecordUGCHudWidgetAttributeCommand : RecordCommand
{
	[Token(Token = "0x400E07A")]
	[FieldOffset(Offset = "0x10")]
	private UIUGCHudWidgetAttributeBaseController m_AttributeController;

	[Token(Token = "0x400E07B")]
	[FieldOffset(Offset = "0x14")]
	private object m_InitValue;

	[Token(Token = "0x400E07C")]
	[FieldOffset(Offset = "0x18")]
	private object m_CurrentValue;

	[Token(Token = "0x600CB80")]
	[Address(RVA = "0x23440F8", Offset = "0x23440F8", VA = "0x23440F8")]
	public RecordUGCHudWidgetAttributeCommand()
	{
	}

	[Token(Token = "0x600CB81")]
	[Address(RVA = "0x2344100", Offset = "0x2344100", VA = "0x2344100")]
	public void Set(UIUGCHudWidgetAttributeBaseController attributeController)
	{
	}

	[Token(Token = "0x600CB82")]
	[Address(RVA = "0x23441C4", Offset = "0x23441C4", VA = "0x23441C4", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB83")]
	[Address(RVA = "0x23442B0", Offset = "0x23442B0", VA = "0x23442B0", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB84")]
	[Address(RVA = "0x234439C", Offset = "0x234439C", VA = "0x234439C", Slot = "17")]
	public override void Record()
	{
	}

	[Token(Token = "0x600CB85")]
	[Address(RVA = "0x234445C", Offset = "0x234445C", VA = "0x234445C", Slot = "16")]
	public override void Clear()
	{
	}
}
