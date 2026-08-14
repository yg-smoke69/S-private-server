using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E58")]
internal class AutoTaskCupMatchEntryPopup : AutoPopupTask
{
	[Token(Token = "0x400BF40")]
	[FieldOffset(Offset = "0x8")]
	private UICupMatchLobbyEntryWndController m_Ctrl;

	[Token(Token = "0x400BF41")]
	[FieldOffset(Offset = "0xC")]
	private UIModelCupMatch m_Model;

	[Token(Token = "0x400BF42")]
	private const int UNSHOWED = 0;

	[Token(Token = "0x400BF43")]
	private const int SHOWED = 1;

	[Token(Token = "0x60091CF")]
	[Address(RVA = "0x10F15EC", Offset = "0x10F15EC", VA = "0x10F15EC")]
	public AutoTaskCupMatchEntryPopup()
	{
	}

	[Token(Token = "0x60091D0")]
	[Address(RVA = "0x10F16B4", Offset = "0x10F16B4", VA = "0x10F16B4", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091D1")]
	[Address(RVA = "0x10F17C0", Offset = "0x10F17C0", VA = "0x10F17C0", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091D2")]
	[Address(RVA = "0x10F1F48", Offset = "0x10F1F48", VA = "0x10F1F48", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
