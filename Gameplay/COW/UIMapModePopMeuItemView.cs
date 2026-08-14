using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200388E")]
public class UIMapModePopMeuItemView : UIBaseView
{
	[Token(Token = "0x40175CE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40175CF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x40175D0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HighLight;

	[Token(Token = "0x40175D1")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Sprite;

	[Token(Token = "0x6016D55")]
	[Address(RVA = "0x2806B04", Offset = "0x2806B04", VA = "0x2806B04")]
	public UIMapModePopMeuItemView()
	{
	}

	[Token(Token = "0x6016D56")]
	[Address(RVA = "0x2806B0C", Offset = "0x2806B0C", VA = "0x2806B0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D57")]
	[Address(RVA = "0x2806DC8", Offset = "0x2806DC8", VA = "0x2806DC8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
