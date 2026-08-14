using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E69")]
public class AutoTaskRateGame : AutoPopupTask
{
	[Token(Token = "0x400BF67")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string SHOW_RATEGAME_KEY;

	[Token(Token = "0x400BF68")]
	[FieldOffset(Offset = "0x8")]
	private UIRateGamePopupWindowController m_RateWindow;

	[Token(Token = "0x600921C")]
	[Address(RVA = "0x10F8CB0", Offset = "0x10F8CB0", VA = "0x10F8CB0")]
	public AutoTaskRateGame()
	{
	}

	[Token(Token = "0x600921D")]
	[Address(RVA = "0x10F8CB8", Offset = "0x10F8CB8", VA = "0x10F8CB8", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600921E")]
	[Address(RVA = "0x10F911C", Offset = "0x10F911C", VA = "0x10F911C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600921F")]
	[Address(RVA = "0x10F921C", Offset = "0x10F921C", VA = "0x10F921C", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
