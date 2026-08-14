using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003257")]
public class DownloadInfoSpecific
{
	[Token(Token = "0x4013258")]
	[FieldOffset(Offset = "0x8")]
	public string Color;

	[Token(Token = "0x4013259")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x401325A")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> ItemIds;

	[Token(Token = "0x401325B")]
	[FieldOffset(Offset = "0x14")]
	public List<ResourceID> ResourceIDs;

	[Token(Token = "0x60153BF")]
	[Address(RVA = "0x1C94C70", Offset = "0x1C94C70", VA = "0x1C94C70")]
	public DownloadInfoSpecific()
	{
	}
}
