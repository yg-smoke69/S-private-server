using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200166E")]
public class CSUnlockProfileReq
{
	[Token(Token = "0x4009628")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x4009629")]
	[FieldOffset(Offset = "0xC")]
	public uint unlock_level;

	[Token(Token = "0x400962A")]
	[FieldOffset(Offset = "0x10")]
	public bool use_general_debris;

	[Token(Token = "0x6007CB8")]
	[Address(RVA = "0x309A4AC", Offset = "0x309A4AC", VA = "0x309A4AC")]
	public CSUnlockProfileReq()
	{
	}
}
