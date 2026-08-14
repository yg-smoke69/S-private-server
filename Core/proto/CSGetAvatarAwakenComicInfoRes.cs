using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001689")]
public class CSGetAvatarAwakenComicInfoRes
{
	[Token(Token = "0x4009663")]
	[FieldOffset(Offset = "0x8")]
	public List<AwakenComic> awaken_comic_info;

	[Token(Token = "0x6007CD3")]
	[Address(RVA = "0x3181BC8", Offset = "0x3181BC8", VA = "0x3181BC8")]
	public CSGetAvatarAwakenComicInfoRes()
	{
	}
}
