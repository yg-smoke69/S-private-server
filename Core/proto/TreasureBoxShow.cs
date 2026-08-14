using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015E5")]
public class TreasureBoxShow
{
	[Token(Token = "0x400947F")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4009480")]
	[FieldOffset(Offset = "0xC")]
	public List<TreasureBoxShowData> treasure_boxes;

	[Token(Token = "0x6007C2F")]
	[Address(RVA = "0x33E3984", Offset = "0x33E3984", VA = "0x33E3984")]
	public TreasureBoxShow()
	{
	}
}
