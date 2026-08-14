using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016DB")]
public class CSGetGachaInfoRes
{
	[Token(Token = "0x4009781")]
	[FieldOffset(Offset = "0x8")]
	public List<GachaInfo> gacha_info_list;

	[Token(Token = "0x4009782")]
	[FieldOffset(Offset = "0xC")]
	public List<CompletionBackpackInfo> completion_backpack_list;

	[Token(Token = "0x6007D35")]
	[Address(RVA = "0x318575C", Offset = "0x318575C", VA = "0x318575C")]
	public CSGetGachaInfoRes()
	{
	}
}
