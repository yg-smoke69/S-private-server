using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;

namespace COW.UGCHudEdit;

[Token(Token = "0x2002404")]
public class SelectHudWidgetCommand : Command
{
	[Token(Token = "0x400E082")]
	[FieldOffset(Offset = "0x10")]
	private UGCHudWidget m_Target;

	[Token(Token = "0x400E083")]
	[FieldOffset(Offset = "0x14")]
	private UGCHudWidget m_LastTarget;

	[Token(Token = "0x400E084")]
	[FieldOffset(Offset = "0x18")]
	private UIModelUGCHudEdit m_Model;

	[Token(Token = "0x600CB8C")]
	[Address(RVA = "0x234498C", Offset = "0x234498C", VA = "0x234498C")]
	public SelectHudWidgetCommand()
	{
	}

	[Token(Token = "0x600CB8D")]
	[Address(RVA = "0x2344994", Offset = "0x2344994", VA = "0x2344994")]
	public void Set(UGCHudWidget target)
	{
	}

	[Token(Token = "0x600CB8E")]
	[Address(RVA = "0x2344A58", Offset = "0x2344A58", VA = "0x2344A58", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB8F")]
	[Address(RVA = "0x2344AB4", Offset = "0x2344AB4", VA = "0x2344AB4", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB90")]
	[Address(RVA = "0x2344AE8", Offset = "0x2344AE8", VA = "0x2344AE8", Slot = "16")]
	public override void Clear()
	{
	}
}
