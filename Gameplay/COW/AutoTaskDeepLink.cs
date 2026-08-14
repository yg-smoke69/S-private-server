using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E5D")]
internal class AutoTaskDeepLink : AutoPopupTask
{
	[Token(Token = "0x60091E3")]
	[Address(RVA = "0x10F3338", Offset = "0x10F3338", VA = "0x10F3338")]
	public AutoTaskDeepLink()
	{
	}

	[Token(Token = "0x60091E4")]
	[Address(RVA = "0x10F3340", Offset = "0x10F3340", VA = "0x10F3340", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091E5")]
	[Address(RVA = "0x10F3398", Offset = "0x10F3398", VA = "0x10F3398", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091E6")]
	[Address(RVA = "0x10F33F0", Offset = "0x10F33F0", VA = "0x10F33F0", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
