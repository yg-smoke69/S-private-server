using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000C97")]
public class ItemFunctionUIData
{
	[Token(Token = "0x4006731")]
	[FieldOffset(Offset = "0x8")]
	public string Title;

	[Token(Token = "0x4006732")]
	[FieldOffset(Offset = "0xC")]
	public List<ItemFunctionUIButtonData> ButtonList;

	[Token(Token = "0x6006034")]
	[Address(RVA = "0x3111C1C", Offset = "0x3111C1C", VA = "0x3111C1C")]
	public ItemFunctionUIData()
	{
	}
}
