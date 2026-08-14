using GCommon.CommandPattern;
using Il2CppDummyDll;

namespace COW.UGCHudEdit;

[Token(Token = "0x2002403")]
public class RecordUGCHudWidgetHierarchyCommand : RecordCommand
{
	[Token(Token = "0x400E07D")]
	[FieldOffset(Offset = "0x10")]
	private UIUGCHudWidgetHierarchyNodeItemController m_Target;

	[Token(Token = "0x400E07E")]
	[FieldOffset(Offset = "0x14")]
	private UIUGCHudWidgetHierarchyNodeItemController m_InitParentNode;

	[Token(Token = "0x400E07F")]
	[FieldOffset(Offset = "0x18")]
	private int m_InitIndex;

	[Token(Token = "0x400E080")]
	[FieldOffset(Offset = "0x1C")]
	private UIUGCHudWidgetHierarchyNodeItemController m_CurrentParentNode;

	[Token(Token = "0x400E081")]
	[FieldOffset(Offset = "0x20")]
	private int m_CurrentIndex;

	[Token(Token = "0x600CB86")]
	[Address(RVA = "0x2344474", Offset = "0x2344474", VA = "0x2344474")]
	public RecordUGCHudWidgetHierarchyCommand()
	{
	}

	[Token(Token = "0x600CB87")]
	[Address(RVA = "0x234447C", Offset = "0x234447C", VA = "0x234447C")]
	public void SetTarget(UIUGCHudWidgetHierarchyNodeItemController item)
	{
	}

	[Token(Token = "0x600CB88")]
	[Address(RVA = "0x234455C", Offset = "0x234455C", VA = "0x234455C", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB89")]
	[Address(RVA = "0x23446FC", Offset = "0x23446FC", VA = "0x23446FC", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB8A")]
	[Address(RVA = "0x234489C", Offset = "0x234489C", VA = "0x234489C", Slot = "17")]
	public override void Record()
	{
	}

	[Token(Token = "0x600CB8B")]
	[Address(RVA = "0x2344978", Offset = "0x2344978", VA = "0x2344978", Slot = "16")]
	public override void Clear()
	{
	}
}
