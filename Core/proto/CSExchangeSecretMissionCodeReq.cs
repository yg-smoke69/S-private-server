using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001619")]
public class CSExchangeSecretMissionCodeReq
{
	[Token(Token = "0x400952E")]
	[FieldOffset(Offset = "0x8")]
	public ulong secret_code;

	[Token(Token = "0x400952F")]
	[FieldOffset(Offset = "0x10")]
	public uint secret_mission_id;

	[Token(Token = "0x6007C63")]
	[Address(RVA = "0x317FF1C", Offset = "0x317FF1C", VA = "0x317FF1C")]
	public CSExchangeSecretMissionCodeReq()
	{
	}
}
