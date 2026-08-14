using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200167F")]
public class CSClaimAwakenTaskRewardsReq
{
	[Token(Token = "0x4009652")]
	[FieldOffset(Offset = "0x8")]
	public uint original_avatar_id;

	[Token(Token = "0x4009653")]
	[FieldOffset(Offset = "0xC")]
	public uint task_type;

	[Token(Token = "0x6007CC9")]
	[Address(RVA = "0x317E520", Offset = "0x317E520", VA = "0x317E520")]
	public CSClaimAwakenTaskRewardsReq()
	{
	}
}
