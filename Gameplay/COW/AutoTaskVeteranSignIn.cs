using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E70")]
internal class AutoTaskVeteranSignIn : AutoPopupTask
{
	[Token(Token = "0x400BF70")]
	[FieldOffset(Offset = "0x8")]
	private UIBaseController m_VeteranUI;

	[Token(Token = "0x6009239")]
	[Address(RVA = "0x10FABB8", Offset = "0x10FABB8", VA = "0x10FABB8")]
	public AutoTaskVeteranSignIn()
	{
	}

	[Token(Token = "0x600923A")]
	[Address(RVA = "0x10FABC0", Offset = "0x10FABC0", VA = "0x10FABC0", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x600923B")]
	[Address(RVA = "0x10FACA8", Offset = "0x10FACA8", VA = "0x10FACA8", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600923C")]
	[Address(RVA = "0x10FAE84", Offset = "0x10FAE84", VA = "0x10FAE84", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
