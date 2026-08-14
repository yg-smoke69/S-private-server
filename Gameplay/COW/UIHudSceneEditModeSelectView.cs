using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003736")]
public class UIHudSceneEditModeSelectView : UIBaseView
{
	[Token(Token = "0x401650E")]
	[FieldOffset(Offset = "0x14")]
	public UISprite FullBg;

	[Token(Token = "0x401650F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ModeNameLabel;

	[Token(Token = "0x4016510")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton SelectBtn;

	[Token(Token = "0x4016511")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Bg;

	[Token(Token = "0x601694D")]
	[Address(RVA = "0x24E4780", Offset = "0x24E4780", VA = "0x24E4780")]
	public UIHudSceneEditModeSelectView()
	{
	}

	[Token(Token = "0x601694E")]
	[Address(RVA = "0x24E4788", Offset = "0x24E4788", VA = "0x24E4788", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601694F")]
	[Address(RVA = "0x24E4A50", Offset = "0x24E4A50", VA = "0x24E4A50")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
