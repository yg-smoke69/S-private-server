using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;

namespace COW.UGCHudEdit;

[Token(Token = "0x2002406")]
public class SetHudWidgetLocalAngleZCommand : Command
{
	[Token(Token = "0x400E088")]
	[FieldOffset(Offset = "0x10")]
	private UGCHudWidget m_Target;

	[Token(Token = "0x400E089")]
	[FieldOffset(Offset = "0x14")]
	private float m_LocalAngleZ;

	[Token(Token = "0x400E08A")]
	[FieldOffset(Offset = "0x18")]
	private float m_LastLocalAngelZ;

	[Token(Token = "0x600CB96")]
	[Address(RVA = "0x2344E50", Offset = "0x2344E50", VA = "0x2344E50")]
	public SetHudWidgetLocalAngleZCommand()
	{
	}

	[Token(Token = "0x600CB97")]
	[Address(RVA = "0x2344E58", Offset = "0x2344E58", VA = "0x2344E58")]
	public void Set(UGCHudWidget widget, float localAngleZ)
	{
	}

	[Token(Token = "0x600CB98")]
	[Address(RVA = "0x2344E64", Offset = "0x2344E64", VA = "0x2344E64", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB99")]
	[Address(RVA = "0x2344F4C", Offset = "0x2344F4C", VA = "0x2344F4C", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB9A")]
	[Address(RVA = "0x2345010", Offset = "0x2345010", VA = "0x2345010", Slot = "16")]
	public override void Clear()
	{
	}
}
