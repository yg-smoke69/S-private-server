using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002AFB")]
public class RoomPopMeanData
{
	[Token(Token = "0x40107DC")]
	[FieldOffset(Offset = "0x8")]
	public RoomPlayerInfo m_info;

	[Token(Token = "0x40107DD")]
	[FieldOffset(Offset = "0xC")]
	public int team_index;

	[Token(Token = "0x6011A5B")]
	[Address(RVA = "0x2417788", Offset = "0x2417788", VA = "0x2417788")]
	public RoomPopMeanData()
	{
	}
}
