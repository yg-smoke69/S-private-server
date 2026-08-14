using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015DF")]
public class CSOpenTreasureBoxRes
{
	[Token(Token = "0x4009471")]
	[FieldOffset(Offset = "0x8")]
	public AwardData awards;

	[Token(Token = "0x4009472")]
	[FieldOffset(Offset = "0xC")]
	public uint left_box_num;

	[Token(Token = "0x4009473")]
	[FieldOffset(Offset = "0x10")]
	public List<ExchangedAward> exchangedAwards;

	[Token(Token = "0x6007C29")]
	[Address(RVA = "0x30982A8", Offset = "0x30982A8", VA = "0x30982A8")]
	public CSOpenTreasureBoxRes()
	{
	}
}
