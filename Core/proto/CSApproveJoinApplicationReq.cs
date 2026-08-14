using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200178C")]
public class CSApproveJoinApplicationReq
{
	[Token(Token = "0x4009A8C")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x4009A8D")]
	[FieldOffset(Offset = "0x10")]
	public ulong team_id;

	[Token(Token = "0x6007DE6")]
	[Address(RVA = "0x317DC94", Offset = "0x317DC94", VA = "0x317DC94")]
	public CSApproveJoinApplicationReq()
	{
	}
}
