using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E4A")]
internal class AutoTaskBigEventAutoEntry : AutoPopupTask
{
	[Token(Token = "0x400BF26")]
	[FieldOffset(Offset = "0x8")]
	private UIBigEventLobbyEnterWndControler m_PopupWnd;

	[Token(Token = "0x600918E")]
	[Address(RVA = "0x10E99E4", Offset = "0x10E99E4", VA = "0x10E99E4")]
	public AutoTaskBigEventAutoEntry()
	{
	}

	[Token(Token = "0x600918F")]
	[Address(RVA = "0x10E99EC", Offset = "0x10E99EC", VA = "0x10E99EC", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x6009190")]
	[Address(RVA = "0x10E9AF8", Offset = "0x10E9AF8", VA = "0x10E9AF8", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009191")]
	[Address(RVA = "0x10E9FD8", Offset = "0x10E9FD8", VA = "0x10E9FD8", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
