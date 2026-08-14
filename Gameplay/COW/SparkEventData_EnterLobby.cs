using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E0A")]
internal class SparkEventData_EnterLobby : SparkEventData_Base
{
	[Token(Token = "0x400BE42")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x400BE43")]
	[FieldOffset(Offset = "0x14")]
	public string region;

	[Token(Token = "0x400BE44")]
	[FieldOffset(Offset = "0x18")]
	public string language;

	[Token(Token = "0x6008FB6")]
	[Address(RVA = "0x20F53DC", Offset = "0x20F53DC", VA = "0x20F53DC")]
	public SparkEventData_EnterLobby()
	{
	}

	[Token(Token = "0x6008FB7")]
	[Address(RVA = "0x20F53E4", Offset = "0x20F53E4", VA = "0x20F53E4", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
