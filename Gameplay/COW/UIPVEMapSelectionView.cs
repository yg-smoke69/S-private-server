using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003934")]
public class UIPVEMapSelectionView : UIBaseView
{
	[Token(Token = "0x4017EEC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton diffcultyBtn;

	[Token(Token = "0x4017EED")]
	[FieldOffset(Offset = "0x18")]
	public UILabel difficulty;

	[Token(Token = "0x4017EEE")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject arr;

	[Token(Token = "0x4017EEF")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ContainerBGCollider;

	[Token(Token = "0x4017EF0")]
	[FieldOffset(Offset = "0x24")]
	public GameObject difficultyPanel;

	[Token(Token = "0x4017EF1")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid grid;

	[Token(Token = "0x4017EF2")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton btn1;

	[Token(Token = "0x4017EF3")]
	[FieldOffset(Offset = "0x30")]
	public UILabel btn1Label;

	[Token(Token = "0x4017EF4")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton btn2;

	[Token(Token = "0x4017EF5")]
	[FieldOffset(Offset = "0x38")]
	public UILabel btn2Label;

	[Token(Token = "0x4017EF6")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite mapSprite;

	[Token(Token = "0x4017EF7")]
	[FieldOffset(Offset = "0x40")]
	public UIButton infoBtn;

	[Token(Token = "0x6016F43")]
	[Address(RVA = "0x15A94F4", Offset = "0x15A94F4", VA = "0x15A94F4")]
	public UIPVEMapSelectionView()
	{
	}

	[Token(Token = "0x6016F44")]
	[Address(RVA = "0x15A94FC", Offset = "0x15A94FC", VA = "0x15A94FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F45")]
	[Address(RVA = "0x15A9AAC", Offset = "0x15A9AAC", VA = "0x15A9AAC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
