using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200178D")]
public class CSDeclineJoinApplicationReq
{
	[Token(Token = "0x4009A8E")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] applicant_ids;

	[Token(Token = "0x4009A8F")]
	[FieldOffset(Offset = "0x10")]
	public ulong team_id;

	[Token(Token = "0x6007DE7")]
	[Address(RVA = "0x317F588", Offset = "0x317F588", VA = "0x317F588")]
	public CSDeclineJoinApplicationReq()
	{
	}
}
