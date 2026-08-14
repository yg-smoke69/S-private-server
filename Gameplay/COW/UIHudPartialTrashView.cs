using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036CC")]
public class UIHudPartialTrashView : UIBaseView
{
	[Token(Token = "0x40161EC")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ItemIcon;

	[Token(Token = "0x40161ED")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ItemName;

	[Token(Token = "0x40161EE")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton MinusBtn;

	[Token(Token = "0x40161EF")]
	[FieldOffset(Offset = "0x20")]
	public UIButton PlusBtn;

	[Token(Token = "0x40161F0")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SelectCnt;

	[Token(Token = "0x40161F1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel MaxCnt;

	[Token(Token = "0x40161F2")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton CancelBtn;

	[Token(Token = "0x40161F3")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ComfirmBtn;

	[Token(Token = "0x40161F4")]
	[FieldOffset(Offset = "0x34")]
	public UISlider CntSlider;

	[Token(Token = "0x40161F5")]
	[FieldOffset(Offset = "0x38")]
	public UISprite BG;

	[Token(Token = "0x40161F6")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget Upper;

	[Token(Token = "0x40161F7")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget Downer;

	[Token(Token = "0x40161F8")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget Center;

	[Token(Token = "0x6016811")]
	[Address(RVA = "0x183DD74", Offset = "0x183DD74", VA = "0x183DD74")]
	public UIHudPartialTrashView()
	{
	}

	[Token(Token = "0x6016812")]
	[Address(RVA = "0x183DD7C", Offset = "0x183DD7C", VA = "0x183DD7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016813")]
	[Address(RVA = "0x183E3A4", Offset = "0x183E3A4", VA = "0x183E3A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
