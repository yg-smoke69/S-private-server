using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003686")]
internal class UIHudItemView : UIBaseView
{
	[Token(Token = "0x4015EDD")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SpriteItemIcon;

	[Token(Token = "0x4015EDE")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnItemAction;

	[Token(Token = "0x601673F")]
	[Address(RVA = "0x20B08C8", Offset = "0x20B08C8", VA = "0x20B08C8")]
	public UIHudItemView()
	{
	}

	[Token(Token = "0x6016740")]
	[Address(RVA = "0x20B08D0", Offset = "0x20B08D0", VA = "0x20B08D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016741")]
	[Address(RVA = "0x20B0A38", Offset = "0x20B0A38", VA = "0x20B0A38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
