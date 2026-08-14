using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001921")]
public class CSCollectJumpsuitStorageRes
{
	[Token(Token = "0x4009EDB")]
	[FieldOffset(Offset = "0x8")]
	public float curr_amount;

	[Token(Token = "0x4009EDC")]
	[FieldOffset(Offset = "0xC")]
	public float curr_storage;

	[Token(Token = "0x4009EDD")]
	[FieldOffset(Offset = "0x10")]
	public long update_time;

	[Token(Token = "0x6007F7A")]
	[Address(RVA = "0x317F0AC", Offset = "0x317F0AC", VA = "0x317F0AC")]
	public CSCollectJumpsuitStorageRes()
	{
	}
}
