using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038D9")]
public class UIOBHudInfoListView : UIBaseView
{
	[Token(Token = "0x4017932")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RightClose;

	[Token(Token = "0x4017933")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition Pivot;

	[Token(Token = "0x4017934")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject InfoPanel;

	[Token(Token = "0x4017935")]
	[FieldOffset(Offset = "0x20")]
	public GameObject playerTab;

	[Token(Token = "0x4017936")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton PlayerToggleBtn;

	[Token(Token = "0x4017937")]
	[FieldOffset(Offset = "0x28")]
	public GameObject airdropTab;

	[Token(Token = "0x4017938")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton AirdropToggleBtn;

	[Token(Token = "0x4017939")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Airdrop;

	[Token(Token = "0x401793A")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView AirdropList;

	[Token(Token = "0x401793B")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid AirdropGrid;

	[Token(Token = "0x401793C")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Player;

	[Token(Token = "0x401793D")]
	[FieldOffset(Offset = "0x40")]
	public UIScrollView PlayerList;

	[Token(Token = "0x401793E")]
	[FieldOffset(Offset = "0x44")]
	public UIEasyList PlayerGrid;

	[Token(Token = "0x401793F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject PCBG;

	[Token(Token = "0x4017940")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject MobileBG;

	[Token(Token = "0x4017941")]
	[FieldOffset(Offset = "0x50")]
	public GameObject GlassBG;

	[Token(Token = "0x6016E34")]
	[Address(RVA = "0x26E3B24", Offset = "0x26E3B24", VA = "0x26E3B24")]
	public UIOBHudInfoListView()
	{
	}

	[Token(Token = "0x6016E35")]
	[Address(RVA = "0x26E3B2C", Offset = "0x26E3B2C", VA = "0x26E3B2C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E36")]
	[Address(RVA = "0x26E4214", Offset = "0x26E4214", VA = "0x26E4214")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
