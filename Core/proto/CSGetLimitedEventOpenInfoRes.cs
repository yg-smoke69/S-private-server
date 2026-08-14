using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017EA")]
public class CSGetLimitedEventOpenInfoRes
{
	[Token(Token = "0x4009BAD")]
	[FieldOffset(Offset = "0x8")]
	public List<BigEventOpenInfoDesc> open_infos;

	[Token(Token = "0x4009BAE")]
	[FieldOffset(Offset = "0xC")]
	public List<BigEventCDNDesc> cdns;

	[Token(Token = "0x4009BAF")]
	[FieldOffset(Offset = "0x10")]
	public List<BigEventEntryDesc> entries;

	[Token(Token = "0x4009BB0")]
	[FieldOffset(Offset = "0x14")]
	public List<BigEventEntranceSettingDesc> entrances;

	[Token(Token = "0x4009BB1")]
	[FieldOffset(Offset = "0x18")]
	public List<BigEventMovieDesc> movies;

	[Token(Token = "0x6007E44")]
	[Address(RVA = "0x3186BBC", Offset = "0x3186BBC", VA = "0x3186BBC")]
	public CSGetLimitedEventOpenInfoRes()
	{
	}
}
