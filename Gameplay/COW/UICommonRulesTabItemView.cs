using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200347F")]
public class UICommonRulesTabItemView : UIBaseView
{
	[Token(Token = "0x40146E5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UICommonRulesTabItem;

	[Token(Token = "0x40146E6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelUniversal;

	[Token(Token = "0x40146E7")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelUniversalUnSelected;

	[Token(Token = "0x40146E8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SpriteUniversalSelected;

	[Token(Token = "0x6016131")]
	[Address(RVA = "0x1EB31EC", Offset = "0x1EB31EC", VA = "0x1EB31EC")]
	public UICommonRulesTabItemView()
	{
	}

	[Token(Token = "0x6016132")]
	[Address(RVA = "0x1EB31F4", Offset = "0x1EB31F4", VA = "0x1EB31F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016133")]
	[Address(RVA = "0x1EB34B0", Offset = "0x1EB34B0", VA = "0x1EB34B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
