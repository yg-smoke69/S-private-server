using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;

namespace COW.UGCHudEdit;

[Token(Token = "0x2002407")]
public class SetHudWidgetNameCommand : Command
{
	[Token(Token = "0x400E08B")]
	[FieldOffset(Offset = "0x10")]
	private UGCHudWidget m_Target;

	[Token(Token = "0x400E08C")]
	[FieldOffset(Offset = "0x14")]
	private string m_Name;

	[Token(Token = "0x400E08D")]
	[FieldOffset(Offset = "0x18")]
	private string m_LastName;

	[Token(Token = "0x600CB9B")]
	[Address(RVA = "0x2345020", Offset = "0x2345020", VA = "0x2345020")]
	public SetHudWidgetNameCommand()
	{
	}

	[Token(Token = "0x600CB9C")]
	[Address(RVA = "0x2345028", Offset = "0x2345028", VA = "0x2345028")]
	public void Set(UGCHudWidget widget, string newName)
	{
	}

	[Token(Token = "0x600CB9D")]
	[Address(RVA = "0x2345034", Offset = "0x2345034", VA = "0x2345034", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB9E")]
	[Address(RVA = "0x2345110", Offset = "0x2345110", VA = "0x2345110", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB9F")]
	[Address(RVA = "0x23451C8", Offset = "0x23451C8", VA = "0x23451C8", Slot = "16")]
	public override void Clear()
	{
	}
}
