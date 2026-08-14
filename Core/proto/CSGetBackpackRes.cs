using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015AF")]
public class CSGetBackpackRes
{
	[Token(Token = "0x40093E8")]
	[FieldOffset(Offset = "0x8")]
	public AccountWallet wallet;

	[Token(Token = "0x40093E9")]
	[FieldOffset(Offset = "0xC")]
	public SelectedItems selected_items;

	[Token(Token = "0x40093EA")]
	[FieldOffset(Offset = "0x10")]
	public List<Item> items;

	[Token(Token = "0x40093EB")]
	[FieldOffset(Offset = "0x14")]
	public MaxLobbyDisplayInfo max_lobby_display;

	[Token(Token = "0x6007BF9")]
	[Address(RVA = "0x3181F64", Offset = "0x3181F64", VA = "0x3181F64")]
	public CSGetBackpackRes()
	{
	}
}
