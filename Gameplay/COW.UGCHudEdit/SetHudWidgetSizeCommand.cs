using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;

namespace COW.UGCHudEdit;

[Token(Token = "0x2002408")]
public class SetHudWidgetSizeCommand : Command
{
	[Token(Token = "0x400E08E")]
	[FieldOffset(Offset = "0x10")]
	private UGCHudWidget m_Target;

	[Token(Token = "0x400E08F")]
	[FieldOffset(Offset = "0x14")]
	private int m_Width;

	[Token(Token = "0x400E090")]
	[FieldOffset(Offset = "0x18")]
	private int m_Height;

	[Token(Token = "0x400E091")]
	[FieldOffset(Offset = "0x1C")]
	private int m_LastWidth;

	[Token(Token = "0x400E092")]
	[FieldOffset(Offset = "0x20")]
	private int m_LastHeight;

	[Token(Token = "0x600CBA0")]
	[Address(RVA = "0x23451D8", Offset = "0x23451D8", VA = "0x23451D8")]
	public SetHudWidgetSizeCommand()
	{
	}

	[Token(Token = "0x600CBA1")]
	[Address(RVA = "0x23451E0", Offset = "0x23451E0", VA = "0x23451E0")]
	public void Set(UGCHudWidget widget, int width, int height)
	{
	}

	[Token(Token = "0x600CBA2")]
	[Address(RVA = "0x23451EC", Offset = "0x23451EC", VA = "0x23451EC", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CBA3")]
	[Address(RVA = "0x2345314", Offset = "0x2345314", VA = "0x2345314", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CBA4")]
	[Address(RVA = "0x23453F4", Offset = "0x23453F4", VA = "0x23453F4", Slot = "16")]
	public override void Clear()
	{
	}
}
