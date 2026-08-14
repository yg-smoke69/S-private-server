using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;

namespace COW.UGCHudEdit;

[Token(Token = "0x20023FF")]
public class DeleteHudWidgetCommand : Command
{
	[Token(Token = "0x400E071")]
	[FieldOffset(Offset = "0x10")]
	private UGCHudWidget m_Target;

	[Token(Token = "0x400E072")]
	[FieldOffset(Offset = "0x14")]
	private UIModelUGCHudEdit m_Model;

	[Token(Token = "0x600CB6E")]
	[Address(RVA = "0x2343584", Offset = "0x2343584", VA = "0x2343584")]
	public DeleteHudWidgetCommand()
	{
	}

	[Token(Token = "0x600CB6F")]
	[Address(RVA = "0x234358C", Offset = "0x234358C", VA = "0x234358C")]
	public void Set(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CB70")]
	[Address(RVA = "0x2343650", Offset = "0x2343650", VA = "0x2343650", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB71")]
	[Address(RVA = "0x2343748", Offset = "0x2343748", VA = "0x2343748", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB72")]
	[Address(RVA = "0x2343840", Offset = "0x2343840", VA = "0x2343840", Slot = "16")]
	public override void Clear()
	{
	}
}
