using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001D6")]
public class PatchOptionalModelData
{
	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x8")]
	public uint OptionalReDefId;

	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0xC")]
	public bool isRecommend;

	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x10")]
	public List<string> ab_pathList;

	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x14")]
	public ResDownloadType resdownloadType;

	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x18")]
	public uint CategoryType;

	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x28D3020", Offset = "0x28D3020", VA = "0x28D3020")]
	public PatchOptionalModelData()
	{
	}
}
