using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014DC")]
public class HurricaneBAccountInfo
{
	[Token(Token = "0x4009012")]
	[FieldOffset(Offset = "0x8")]
	public List<HurricaneBMissionInfo> missions;

	[Token(Token = "0x4009013")]
	[FieldOffset(Offset = "0x10")]
	public ulong team_id;

	[Token(Token = "0x6007B31")]
	[Address(RVA = "0x30A31AC", Offset = "0x30A31AC", VA = "0x30A31AC")]
	public HurricaneBAccountInfo()
	{
	}
}
