using Il2CppDummyDll;

[Token(Token = "0x200043F")]
public class BountyInGameCutscene : InGameCutscene
{
	[Token(Token = "0x4003C18")]
	[FieldOffset(Offset = "0x44")]
	public bool IsOnlyLowMemoryNeedBlackMask;

	[Token(Token = "0x6001533")]
	[Address(RVA = "0x2ED61D4", Offset = "0x2ED61D4", VA = "0x2ED61D4")]
	public BountyInGameCutscene()
	{
	}

	[Token(Token = "0x6001534")]
	[Address(RVA = "0x2ED61E4", Offset = "0x2ED61E4", VA = "0x2ED61E4", Slot = "4")]
	public override void UpdateBlackMask()
	{
	}
}
