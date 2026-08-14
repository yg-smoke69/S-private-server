using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001725")]
public class GetAttendanceRes
{
	[Token(Token = "0x4009923")]
	[FieldOffset(Offset = "0x8")]
	public CSGetNewPlayerRewardsListRes new_player_res;

	[Token(Token = "0x4009924")]
	[FieldOffset(Offset = "0xC")]
	public CSGetAttendanceListRes attendance_res;

	[Token(Token = "0x4009925")]
	[FieldOffset(Offset = "0x10")]
	public CSGetVeteranRewardListRes veteran_res;

	[Token(Token = "0x4009926")]
	[FieldOffset(Offset = "0x14")]
	public CSClanSignInRes clan_sign_in_info;

	[Token(Token = "0x4009927")]
	[FieldOffset(Offset = "0x18")]
	public CSGetBatchShowContentRes batch_show_content;

	[Token(Token = "0x6007D7F")]
	[Address(RVA = "0x30A1E8C", Offset = "0x30A1E8C", VA = "0x30A1E8C")]
	public GetAttendanceRes()
	{
	}
}
