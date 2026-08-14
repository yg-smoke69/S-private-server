using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200187F")]
public class CSGetBattleTagRes
{
	[Token(Token = "0x4009D15")]
	[FieldOffset(Offset = "0x8")]
	public List<BattleTagCount> battle_tag_counts;

	[Token(Token = "0x4009D16")]
	[FieldOffset(Offset = "0xC")]
	public uint[] show_tag_ids;

	[Token(Token = "0x6007ED8")]
	[Address(RVA = "0x318207C", Offset = "0x318207C", VA = "0x318207C")]
	public CSGetBattleTagRes()
	{
	}
}
