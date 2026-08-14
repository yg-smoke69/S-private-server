using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039BF")]
public class UISPHudInfoListView : UIBaseView
{
	[Token(Token = "0x4018446")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RightClose;

	[Token(Token = "0x4018447")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition Pivot;

	[Token(Token = "0x4018448")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject InfoPanel;

	[Token(Token = "0x4018449")]
	[FieldOffset(Offset = "0x20")]
	public GameObject playerTab;

	[Token(Token = "0x401844A")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton PlayerToggleBtn;

	[Token(Token = "0x401844B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject airdropTab;

	[Token(Token = "0x401844C")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton AirdropToggleBtn;

	[Token(Token = "0x401844D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Airdrop;

	[Token(Token = "0x401844E")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView AirdropList;

	[Token(Token = "0x401844F")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid AirdropGrid;

	[Token(Token = "0x4018450")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Player;

	[Token(Token = "0x4018451")]
	[FieldOffset(Offset = "0x40")]
	public UIScrollView PlayerList;

	[Token(Token = "0x4018452")]
	[FieldOffset(Offset = "0x44")]
	public UIEasyList PlayerGrid;

	[Token(Token = "0x4018453")]
	[FieldOffset(Offset = "0x48")]
	public GameObject PCBG;

	[Token(Token = "0x4018454")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject MobileBG;

	[Token(Token = "0x4018455")]
	[FieldOffset(Offset = "0x50")]
	public GameObject GlassBG;

	[Token(Token = "0x60170E4")]
	[Address(RVA = "0x1D1EF9C", Offset = "0x1D1EF9C", VA = "0x1D1EF9C")]
	public UISPHudInfoListView()
	{
	}

	[Token(Token = "0x60170E5")]
	[Address(RVA = "0x1D1EFA4", Offset = "0x1D1EFA4", VA = "0x1D1EFA4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170E6")]
	[Address(RVA = "0x1D1F56C", Offset = "0x1D1F56C", VA = "0x1D1F56C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
