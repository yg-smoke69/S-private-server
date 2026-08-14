using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;

namespace COW.UGCHudEdit;

[Token(Token = "0x20023FD")]
public class AdjustHudWidgetSelectorAngleCommand : RecordCommand
{
	[Token(Token = "0x400E064")]
	[FieldOffset(Offset = "0x10")]
	private UIUGCHudWidgetSelectorController m_Selector;

	[Token(Token = "0x400E065")]
	[FieldOffset(Offset = "0x14")]
	private UGCHudWidget m_BindWidget;

	[Token(Token = "0x400E066")]
	[FieldOffset(Offset = "0x18")]
	private float m_InitLocalAngleZ;

	[Token(Token = "0x400E067")]
	[FieldOffset(Offset = "0x1C")]
	private float m_LocalAngleZ;

	[Token(Token = "0x600CB5F")]
	[Address(RVA = "0x2342B00", Offset = "0x2342B00", VA = "0x2342B00")]
	public AdjustHudWidgetSelectorAngleCommand()
	{
	}

	[Token(Token = "0x600CB60")]
	[Address(RVA = "0x2342B08", Offset = "0x2342B08", VA = "0x2342B08")]
	public void Set(UIUGCHudWidgetSelectorController selector)
	{
	}

	[Token(Token = "0x600CB61")]
	[Address(RVA = "0x2342B94", Offset = "0x2342B94", VA = "0x2342B94", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB62")]
	[Address(RVA = "0x2342D54", Offset = "0x2342D54", VA = "0x2342D54", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB63")]
	[Address(RVA = "0x2342DFC", Offset = "0x2342DFC", VA = "0x2342DFC", Slot = "17")]
	public override void Record()
	{
	}

	[Token(Token = "0x600CB64")]
	[Address(RVA = "0x2342EE0", Offset = "0x2342EE0", VA = "0x2342EE0", Slot = "16")]
	public override void Clear()
	{
	}

	[Token(Token = "0x600CB65")]
	[Address(RVA = "0x2342C3C", Offset = "0x2342C3C", VA = "0x2342C3C")]
	private void SetRotation(float deltaAngle)
	{
	}
}
