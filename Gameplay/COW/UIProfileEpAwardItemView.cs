using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003925")]
public class UIProfileEpAwardItemView : UIBaseView
{
	[Token(Token = "0x4017CB8")]
	[FieldOffset(Offset = "0x14")]
	public UISprite EPAwardicon;

	[Token(Token = "0x4017CB9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel EPAwardnum;

	[Token(Token = "0x6016F16")]
	[Address(RVA = "0x16D67E0", Offset = "0x16D67E0", VA = "0x16D67E0")]
	public UIProfileEpAwardItemView()
	{
	}

	[Token(Token = "0x6016F17")]
	[Address(RVA = "0x16D67E8", Offset = "0x16D67E8", VA = "0x16D67E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F18")]
	[Address(RVA = "0x16D69F0", Offset = "0x16D69F0", VA = "0x16D69F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
