using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032BE")]
public class SuitOpenInfo
{
	[Token(Token = "0x401351E")]
	[FieldOffset(Offset = "0x8")]
	public uint SuitId;

	[Token(Token = "0x401351F")]
	[FieldOffset(Offset = "0xC")]
	public bool IsOpenning;

	[Token(Token = "0x4013520")]
	[FieldOffset(Offset = "0x10")]
	public long OpenTime;

	[Token(Token = "0x6015695")]
	[Address(RVA = "0x2891920", Offset = "0x2891920", VA = "0x2891920")]
	public SuitOpenInfo()
	{
	}
}
