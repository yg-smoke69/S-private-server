using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037BD")]
public class UIHUDUseTrapView : UIBaseView
{
	[Token(Token = "0x4016957")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ShowRoot;

	[Token(Token = "0x4016958")]
	[FieldOffset(Offset = "0x18")]
	public UIButton UseBtn;

	[Token(Token = "0x4016959")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite icon;

	[Token(Token = "0x401695A")]
	[FieldOffset(Offset = "0x20")]
	public UISprite bg;

	[Token(Token = "0x401695B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TrapCountLabel;

	[Token(Token = "0x6016AE2")]
	[Address(RVA = "0x293447C", Offset = "0x293447C", VA = "0x293447C")]
	public UIHUDUseTrapView()
	{
	}

	[Token(Token = "0x6016AE3")]
	[Address(RVA = "0x2934484", Offset = "0x2934484", VA = "0x2934484", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AE4")]
	[Address(RVA = "0x29347A0", Offset = "0x29347A0", VA = "0x29347A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
