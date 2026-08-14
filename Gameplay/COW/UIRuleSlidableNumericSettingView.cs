using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003982")]
public class UIRuleSlidableNumericSettingView : UIBaseView
{
	[Token(Token = "0x401815F")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Self;

	[Token(Token = "0x4018160")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x4018161")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Title;

	[Token(Token = "0x4018162")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Tip;

	[Token(Token = "0x4018163")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Value;

	[Token(Token = "0x4018164")]
	[FieldOffset(Offset = "0x28")]
	public UIButton PlusBtn;

	[Token(Token = "0x4018165")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton SubBtn;

	[Token(Token = "0x4018166")]
	[FieldOffset(Offset = "0x30")]
	public UISlider Slider;

	[Token(Token = "0x4018167")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Indicator;

	[Token(Token = "0x601702D")]
	[Address(RVA = "0x141F2BC", Offset = "0x141F2BC", VA = "0x141F2BC")]
	public UIRuleSlidableNumericSettingView()
	{
	}

	[Token(Token = "0x601702E")]
	[Address(RVA = "0x141F2C4", Offset = "0x141F2C4", VA = "0x141F2C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601702F")]
	[Address(RVA = "0x141F76C", Offset = "0x141F76C", VA = "0x141F76C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
