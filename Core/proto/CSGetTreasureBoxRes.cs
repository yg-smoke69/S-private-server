using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015E0")]
public class CSGetTreasureBoxRes
{
	[Token(Token = "0x4009474")]
	[FieldOffset(Offset = "0x8")]
	public List<TreasureBoxShow> boxes;

	[Token(Token = "0x4009475")]
	[FieldOffset(Offset = "0xC")]
	public List<CrateDescs> crates;

	[Token(Token = "0x6007C2A")]
	[Address(RVA = "0x3095C64", Offset = "0x3095C64", VA = "0x3095C64")]
	public CSGetTreasureBoxRes()
	{
	}
}
