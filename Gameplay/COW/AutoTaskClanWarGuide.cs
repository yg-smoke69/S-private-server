using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002537")]
public class AutoTaskClanWarGuide : AutoPopupTask
{
	[Token(Token = "0x600D87B")]
	[Address(RVA = "0x10EF820", Offset = "0x10EF820", VA = "0x10EF820")]
	public AutoTaskClanWarGuide()
	{
	}

	[Token(Token = "0x600D87C")]
	[Address(RVA = "0x10EF828", Offset = "0x10EF828", VA = "0x10EF828", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600D87D")]
	[Address(RVA = "0x10EFCE8", Offset = "0x10EFCE8", VA = "0x10EFCE8", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600D87E")]
	[Address(RVA = "0x10EFD40", Offset = "0x10EFD40", VA = "0x10EFD40", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
