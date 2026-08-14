using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021DD")]
public class BuyBtnInfo
{
	[Token(Token = "0x400D3CF")]
	[FieldOffset(Offset = "0x8")]
	public string icon;

	[Token(Token = "0x400D3D0")]
	[FieldOffset(Offset = "0xC")]
	public string desc;

	[Token(Token = "0x400D3D1")]
	[FieldOffset(Offset = "0x10")]
	public Callback callback;

	[Token(Token = "0x600B5AC")]
	[Address(RVA = "0x1814E3C", Offset = "0x1814E3C", VA = "0x1814E3C")]
	public BuyBtnInfo(string icon, string desc, Callback callback)
	{
	}
}
