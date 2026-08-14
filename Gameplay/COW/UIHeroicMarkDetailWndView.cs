using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035BE")]
public class UIHeroicMarkDetailWndView : UIBaseView
{
	[Token(Token = "0x4015824")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4015825")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList TabsContainer;

	[Token(Token = "0x4015826")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Desc;

	[Token(Token = "0x4015827")]
	[FieldOffset(Offset = "0x20")]
	public UIButton MoreDetail;

	[Token(Token = "0x4015828")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4015829")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid Grid;

	[Token(Token = "0x401582A")]
	[FieldOffset(Offset = "0x2C")]
	public UIHeroicMarkItemCtrl MarkItem;

	[Token(Token = "0x401582B")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ShareBtn;

	[Token(Token = "0x60164E8")]
	[Address(RVA = "0x162C678", Offset = "0x162C678", VA = "0x162C678")]
	public UIHeroicMarkDetailWndView()
	{
	}

	[Token(Token = "0x60164E9")]
	[Address(RVA = "0x162C680", Offset = "0x162C680", VA = "0x162C680", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164EA")]
	[Address(RVA = "0x162CAC8", Offset = "0x162CAC8", VA = "0x162CAC8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
