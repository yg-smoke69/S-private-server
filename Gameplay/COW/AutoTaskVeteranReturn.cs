using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E6F")]
internal class AutoTaskVeteranReturn : AutoPopupTask
{
	[Token(Token = "0x400BF6D")]
	[FieldOffset(Offset = "0x8")]
	private UIVeteranReturnController m_VeteranReturn;

	[Token(Token = "0x400BF6E")]
	[FieldOffset(Offset = "0xC")]
	private UIVeteranGuideLobbyEnterWndController m_VeteranGuideLobbyEnterWnd;

	[Token(Token = "0x400BF6F")]
	[FieldOffset(Offset = "0x10")]
	private UIModelVeteranSignin m_ModelVeteranSignin;

	[Token(Token = "0x6009235")]
	[Address(RVA = "0x10FA44C", Offset = "0x10FA44C", VA = "0x10FA44C")]
	public AutoTaskVeteranReturn()
	{
	}

	[Token(Token = "0x6009236")]
	[Address(RVA = "0x10FA454", Offset = "0x10FA454", VA = "0x10FA454", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x6009237")]
	[Address(RVA = "0x10FA53C", Offset = "0x10FA53C", VA = "0x10FA53C", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009238")]
	[Address(RVA = "0x10FA9A4", Offset = "0x10FA9A4", VA = "0x10FA9A4", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
