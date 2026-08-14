using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003883")]
public class UIManualMapSupplyItemView : UIBaseView
{
	[Token(Token = "0x40174E4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Button;

	[Token(Token = "0x40174E5")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x40174E6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel QuestionLabel;

	[Token(Token = "0x40174E7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SelectBg;

	[Token(Token = "0x40174E8")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Tag;

	[Token(Token = "0x6016D34")]
	[Address(RVA = "0x2C409B4", Offset = "0x2C409B4", VA = "0x2C409B4")]
	public UIManualMapSupplyItemView()
	{
	}

	[Token(Token = "0x6016D35")]
	[Address(RVA = "0x2C409BC", Offset = "0x2C409BC", VA = "0x2C409BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D36")]
	[Address(RVA = "0x2C40CCC", Offset = "0x2C40CCC", VA = "0x2C40CCC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
