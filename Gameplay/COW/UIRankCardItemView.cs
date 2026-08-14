using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200393E")]
public class UIRankCardItemView : UIBaseView
{
	[Token(Token = "0x4017F3E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton infoBtn;

	[Token(Token = "0x4017F3F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel name;

	[Token(Token = "0x4017F40")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel cnt;

	[Token(Token = "0x4017F41")]
	[FieldOffset(Offset = "0x20")]
	public UISprite iconBG01;

	[Token(Token = "0x4017F42")]
	[FieldOffset(Offset = "0x24")]
	public UIButton itemBtn;

	[Token(Token = "0x4017F43")]
	[FieldOffset(Offset = "0x28")]
	public UISprite icon;

	[Token(Token = "0x4017F44")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HL;

	[Token(Token = "0x4017F45")]
	[FieldOffset(Offset = "0x30")]
	public GameObject NoGotView;

	[Token(Token = "0x4017F46")]
	[FieldOffset(Offset = "0x34")]
	public UILabel label;

	[Token(Token = "0x4017F47")]
	[FieldOffset(Offset = "0x38")]
	public GameObject InactiveIcon;

	[Token(Token = "0x6016F61")]
	[Address(RVA = "0x1AC4390", Offset = "0x1AC4390", VA = "0x1AC4390")]
	public UIRankCardItemView()
	{
	}

	[Token(Token = "0x6016F62")]
	[Address(RVA = "0x1AC4398", Offset = "0x1AC4398", VA = "0x1AC4398", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F63")]
	[Address(RVA = "0x1AC487C", Offset = "0x1AC487C", VA = "0x1AC487C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
