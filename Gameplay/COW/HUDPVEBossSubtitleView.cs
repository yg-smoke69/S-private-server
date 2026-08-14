using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003380")]
public class HUDPVEBossSubtitleView : UIBaseView
{
	[Token(Token = "0x40139E3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x40139E4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ContentLabel;

	[Token(Token = "0x40139E5")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Bg_01;

	[Token(Token = "0x40139E6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Bg_02;

	[Token(Token = "0x6015E37")]
	[Address(RVA = "0x19095C8", Offset = "0x19095C8", VA = "0x19095C8")]
	public HUDPVEBossSubtitleView()
	{
	}

	[Token(Token = "0x6015E38")]
	[Address(RVA = "0x19095D0", Offset = "0x19095D0", VA = "0x19095D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E39")]
	[Address(RVA = "0x190988C", Offset = "0x190988C", VA = "0x190988C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
