using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003445")]
public class UIClanBannerItemView : UIBaseView
{
	[Token(Token = "0x40143F7")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Item;

	[Token(Token = "0x40143F8")]
	[FieldOffset(Offset = "0x18")]
	public UISprite bg;

	[Token(Token = "0x40143F9")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite Banner;

	[Token(Token = "0x40143FA")]
	[FieldOffset(Offset = "0x20")]
	public UISprite MiniBanner;

	[Token(Token = "0x40143FB")]
	[FieldOffset(Offset = "0x24")]
	public UILabel name;

	[Token(Token = "0x6016083")]
	[Address(RVA = "0x2F23C80", Offset = "0x2F23C80", VA = "0x2F23C80")]
	public UIClanBannerItemView()
	{
	}

	[Token(Token = "0x6016084")]
	[Address(RVA = "0x2F23C88", Offset = "0x2F23C88", VA = "0x2F23C88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016085")]
	[Address(RVA = "0x2F23FB0", Offset = "0x2F23FB0", VA = "0x2F23FB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
