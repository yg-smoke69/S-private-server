using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018BB")]
public class CSGetFourSymbolsSettingRes
{
	[Token(Token = "0x4009DAF")]
	[FieldOffset(Offset = "0x8")]
	public FourSymbolsSettingDesc setting;

	[Token(Token = "0x4009DB0")]
	[FieldOffset(Offset = "0xC")]
	public List<FourSymbolsChatDesc> chat_descs;

	[Token(Token = "0x4009DB1")]
	[FieldOffset(Offset = "0x10")]
	public FourSymbolsTreasureMapDesc treasure_map_desc;

	[Token(Token = "0x4009DB2")]
	[FieldOffset(Offset = "0x14")]
	public FourSymbolsSignInDesc sign_in_desc;

	[Token(Token = "0x4009DB3")]
	[FieldOffset(Offset = "0x18")]
	public List<FourSymbolsRoadDesc> road_desc;

	[Token(Token = "0x6007F14")]
	[Address(RVA = "0x3184FF8", Offset = "0x3184FF8", VA = "0x3184FF8")]
	public CSGetFourSymbolsSettingRes()
	{
	}
}
