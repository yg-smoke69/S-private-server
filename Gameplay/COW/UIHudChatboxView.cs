using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200360D")]
public class UIHudChatboxView : UIBaseView
{
	[Token(Token = "0x4015A17")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Label;

	[Token(Token = "0x4015A18")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Sticker;

	[Token(Token = "0x60165D5")]
	[Address(RVA = "0x135C4E0", Offset = "0x135C4E0", VA = "0x135C4E0")]
	public UIHudChatboxView()
	{
	}

	[Token(Token = "0x60165D6")]
	[Address(RVA = "0x135C4E8", Offset = "0x135C4E8", VA = "0x135C4E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165D7")]
	[Address(RVA = "0x135C6F0", Offset = "0x135C6F0", VA = "0x135C6F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
