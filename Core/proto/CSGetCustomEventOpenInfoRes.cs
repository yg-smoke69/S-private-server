using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017D8")]
public class CSGetCustomEventOpenInfoRes
{
	[Token(Token = "0x4009B8B")]
	[FieldOffset(Offset = "0x8")]
	public CustomEventOpenInfoDesc open_info;

	[Token(Token = "0x4009B8C")]
	[FieldOffset(Offset = "0xC")]
	public List<CustomEventEntranceDesc> entrances;

	[Token(Token = "0x4009B8D")]
	[FieldOffset(Offset = "0x10")]
	public List<CustomEventTemplateDesc> templates;

	[Token(Token = "0x4009B8E")]
	[FieldOffset(Offset = "0x14")]
	public List<CustomEventLocDesc> locs;

	[Token(Token = "0x4009B8F")]
	[FieldOffset(Offset = "0x18")]
	public List<CustomEventCDNDesc> cdns;

	[Token(Token = "0x6007E32")]
	[Address(RVA = "0x31839D4", Offset = "0x31839D4", VA = "0x31839D4")]
	public CSGetCustomEventOpenInfoRes()
	{
	}
}
