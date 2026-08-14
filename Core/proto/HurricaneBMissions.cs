using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014DB")]
public class HurricaneBMissions
{
	[Token(Token = "0x4009011")]
	[FieldOffset(Offset = "0x8")]
	public List<HurricaneBMissionInfo> missions;

	[Token(Token = "0x6007B30")]
	[Address(RVA = "0x30A34C0", Offset = "0x30A34C0", VA = "0x30A34C0")]
	public HurricaneBMissions()
	{
	}
}
