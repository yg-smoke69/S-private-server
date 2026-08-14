using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200393F")]
public class UIRankCardListView : UIBaseView
{
	[Token(Token = "0x4017F48")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4017F49")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x4017F4A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NoneUseItemContainer;

	[Token(Token = "0x4017F4B")]
	[FieldOffset(Offset = "0x20")]
	public UIButton NoneUseItemBtn;

	[Token(Token = "0x4017F4C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel NoneUseItemLabel;

	[Token(Token = "0x4017F4D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NoneUseSelectDot;

	[Token(Token = "0x6016F64")]
	[Address(RVA = "0x1AC5608", Offset = "0x1AC5608", VA = "0x1AC5608")]
	public UIRankCardListView()
	{
	}

	[Token(Token = "0x6016F65")]
	[Address(RVA = "0x1AC5610", Offset = "0x1AC5610", VA = "0x1AC5610", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F66")]
	[Address(RVA = "0x1AC5980", Offset = "0x1AC5980", VA = "0x1AC5980")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
