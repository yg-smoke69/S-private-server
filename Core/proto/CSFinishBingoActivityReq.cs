using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001611")]
public class CSFinishBingoActivityReq
{
	[Token(Token = "0x40094ED")]
	[FieldOffset(Offset = "0x8")]
	public uint activity_id;

	[Token(Token = "0x40094EE")]
	[FieldOffset(Offset = "0xC")]
	public uint key_id;

	[Token(Token = "0x40094EF")]
	[FieldOffset(Offset = "0x10")]
	public string language;

	[Token(Token = "0x6007C5B")]
	[Address(RVA = "0x31806B0", Offset = "0x31806B0", VA = "0x31806B0")]
	public CSFinishBingoActivityReq()
	{
	}
}
