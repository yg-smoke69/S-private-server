using Il2CppDummyDll;

[Token(Token = "0x200079B")]
public class TrampleTrigger : MetaTrigger
{
	[Token(Token = "0x4004ED1")]
	[FieldOffset(Offset = "0xC")]
	public uint trampleUniqueID;

	[Token(Token = "0x4004ED2")]
	[FieldOffset(Offset = "0x10")]
	public TrampleObject trampleObj;

	[Token(Token = "0x60030A4")]
	[Address(RVA = "0x263B5A0", Offset = "0x263B5A0", VA = "0x263B5A0")]
	public TrampleTrigger()
	{
	}
}
