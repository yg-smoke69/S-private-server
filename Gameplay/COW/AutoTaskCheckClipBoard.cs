using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E4E")]
public class AutoTaskCheckClipBoard : AutoPopupTask
{
	[Token(Token = "0x400BF2A")]
	[FieldOffset(Offset = "0x8")]
	private UIWorkshopDetailController m_Ctrl;

	[Token(Token = "0x60091A0")]
	[Address(RVA = "0x10EDEC4", Offset = "0x10EDEC4", VA = "0x10EDEC4")]
	public AutoTaskCheckClipBoard()
	{
	}

	[Token(Token = "0x60091A1")]
	[Address(RVA = "0x10EDECC", Offset = "0x10EDECC", VA = "0x10EDECC", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091A2")]
	[Address(RVA = "0x10EE04C", Offset = "0x10EE04C", VA = "0x10EE04C", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091A3")]
	[Address(RVA = "0x10EE1EC", Offset = "0x10EE1EC", VA = "0x10EE1EC", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
