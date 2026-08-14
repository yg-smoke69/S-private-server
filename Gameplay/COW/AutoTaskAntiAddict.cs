using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E49")]
public class AutoTaskAntiAddict : AutoPopupTask
{
	[Token(Token = "0x400BF25")]
	[FieldOffset(Offset = "0x8")]
	private UIAgeVerifyController m_UIAgeVerifyController;

	[Token(Token = "0x600918A")]
	[Address(RVA = "0x10E95A0", Offset = "0x10E95A0", VA = "0x10E95A0")]
	public AutoTaskAntiAddict()
	{
	}

	[Token(Token = "0x600918B")]
	[Address(RVA = "0x10E95A8", Offset = "0x10E95A8", VA = "0x10E95A8", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600918C")]
	[Address(RVA = "0x10E988C", Offset = "0x10E988C", VA = "0x10E988C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600918D")]
	[Address(RVA = "0x10E998C", Offset = "0x10E998C", VA = "0x10E998C", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
