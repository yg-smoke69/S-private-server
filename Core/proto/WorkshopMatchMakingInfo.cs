using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014BD")]
public class WorkshopMatchMakingInfo
{
	[Token(Token = "0x4008FAE")]
	[FieldOffset(Offset = "0x8")]
	public List<string> workshop_codes;

	[Token(Token = "0x4008FAF")]
	[FieldOffset(Offset = "0xC")]
	public bool can_force_sync_workshop_code;

	[Token(Token = "0x4008FB0")]
	[FieldOffset(Offset = "0x10")]
	public uint workshop_team_count;

	[Token(Token = "0x6007B1E")]
	[Address(RVA = "0x33E686C", Offset = "0x33E686C", VA = "0x33E686C")]
	public WorkshopMatchMakingInfo()
	{
	}
}
