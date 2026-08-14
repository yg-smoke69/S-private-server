using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003613")]
public class UIHudCommonlTipsView : UIBaseView
{
	[Token(Token = "0x4015A36")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PosRoot;

	[Token(Token = "0x4015A37")]
	[FieldOffset(Offset = "0x18")]
	public UITable ContentTable;

	[Token(Token = "0x4015A38")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Description;

	[Token(Token = "0x4015A39")]
	[FieldOffset(Offset = "0x20")]
	public UISprite DescriptionBG;

	[Token(Token = "0x4015A3A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Mask;

	[Token(Token = "0x60165E8")]
	[Address(RVA = "0x135FB80", Offset = "0x135FB80", VA = "0x135FB80")]
	public UIHudCommonlTipsView()
	{
	}

	[Token(Token = "0x60165E9")]
	[Address(RVA = "0x135FB88", Offset = "0x135FB88", VA = "0x135FB88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165EA")]
	[Address(RVA = "0x135FE98", Offset = "0x135FE98", VA = "0x135FE98")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
