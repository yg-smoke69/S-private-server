using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017DF")]
public class CSClaimCustomEventProcessRewardsReq
{
	[Token(Token = "0x4009B96")]
	[FieldOffset(Offset = "0x8")]
	public uint custom_event_id;

	[Token(Token = "0x4009B97")]
	[FieldOffset(Offset = "0xC")]
	public uint[] process_ids;

	[Token(Token = "0x6007E39")]
	[Address(RVA = "0x317E598", Offset = "0x317E598", VA = "0x317E598")]
	public CSClaimCustomEventProcessRewardsReq()
	{
	}
}
