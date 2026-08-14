using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017D1")]
public class VeteranTaskInfo
{
	[Token(Token = "0x4009B7E")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4009B7F")]
	[FieldOffset(Offset = "0xC")]
	public uint data;

	[Token(Token = "0x4009B80")]
	[FieldOffset(Offset = "0x10")]
	public EActivity.State state;

	[Token(Token = "0x6007E2B")]
	[Address(RVA = "0x33E488C", Offset = "0x33E488C", VA = "0x33E488C")]
	public VeteranTaskInfo()
	{
	}
}
