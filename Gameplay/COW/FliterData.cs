using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028F7")]
public class FliterData
{
	[Token(Token = "0x400FBF3")]
	[FieldOffset(Offset = "0x8")]
	public string DefaultText;

	[Token(Token = "0x400FBF4")]
	[FieldOffset(Offset = "0xC")]
	public List<FliterItemData> FliterList;

	[Token(Token = "0x400FBF5")]
	[FieldOffset(Offset = "0x10")]
	public UILeaderBoardNewController.DeepLinkLayer DeepLinkLayer;

	[Token(Token = "0x6010316")]
	[Address(RVA = "0xDEDC18", Offset = "0xDEDC18", VA = "0xDEDC18")]
	public FliterData()
	{
	}
}
