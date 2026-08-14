using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200162F")]
public class CSChangeMemberTypeReq
{
	[Token(Token = "0x4009558")]
	[FieldOffset(Offset = "0x8")]
	public ulong changee_id;

	[Token(Token = "0x4009559")]
	[FieldOffset(Offset = "0x10")]
	public uint target_type;

	[Token(Token = "0x6007C79")]
	[Address(RVA = "0x317E2CC", Offset = "0x317E2CC", VA = "0x317E2CC")]
	public CSChangeMemberTypeReq()
	{
	}
}
