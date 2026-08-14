using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016BF")]
public class CSAnnouncementRes
{
	[Token(Token = "0x40096E0")]
	[FieldOffset(Offset = "0x8")]
	public List<AnnouncementDesc> announcements;

	[Token(Token = "0x6007D20")]
	[Address(RVA = "0x317DBE8", Offset = "0x317DBE8", VA = "0x317DBE8")]
	public CSAnnouncementRes()
	{
	}
}
