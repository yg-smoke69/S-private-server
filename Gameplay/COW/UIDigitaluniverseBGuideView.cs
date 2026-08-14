using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034D0")]
public class UIDigitaluniverseBGuideView : UIBaseView
{
	[Token(Token = "0x4014B3F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelGuide;

	[Token(Token = "0x4014B40")]
	[FieldOffset(Offset = "0x18")]
	public TypewriterEffect LabelGuideType;

	[Token(Token = "0x4014B41")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnContionue;

	[Token(Token = "0x4014B42")]
	[FieldOffset(Offset = "0x20")]
	public Animation UIDigitaluniverseBGuide;

	[Token(Token = "0x4014B43")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Guide2Container;

	[Token(Token = "0x4014B44")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Guide3Container;

	[Token(Token = "0x4014B45")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BottomContainer;

	[Token(Token = "0x4014B46")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LabelOpenContainer;

	[Token(Token = "0x4014B47")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Guide1Container;

	[Token(Token = "0x4014B48")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Guide5Container;

	[Token(Token = "0x4014B49")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SpineContainer;

	[Token(Token = "0x4014B4A")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnCloseGuide5;

	[Token(Token = "0x4014B4B")]
	[FieldOffset(Offset = "0x44")]
	public GameObject LabelGuideContainer;

	[Token(Token = "0x6016224")]
	[Address(RVA = "0x2F671AC", Offset = "0x2F671AC", VA = "0x2F671AC")]
	public UIDigitaluniverseBGuideView()
	{
	}

	[Token(Token = "0x6016225")]
	[Address(RVA = "0x2F671B4", Offset = "0x2F671B4", VA = "0x2F671B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016226")]
	[Address(RVA = "0x2F6777C", Offset = "0x2F6777C", VA = "0x2F6777C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
