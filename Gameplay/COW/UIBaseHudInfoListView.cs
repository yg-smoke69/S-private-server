using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033E8")]
public class UIBaseHudInfoListView : UIBaseView
{
	[Token(Token = "0x4013F04")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RightClose;

	[Token(Token = "0x4013F05")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition Pivot;

	[Token(Token = "0x4013F06")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject InfoPanel;

	[Token(Token = "0x4013F07")]
	[FieldOffset(Offset = "0x20")]
	public GameObject playerTab;

	[Token(Token = "0x4013F08")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton PlayerToggleBtn;

	[Token(Token = "0x4013F09")]
	[FieldOffset(Offset = "0x28")]
	public GameObject airdropTab;

	[Token(Token = "0x4013F0A")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton AirdropToggleBtn;

	[Token(Token = "0x4013F0B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Airdrop;

	[Token(Token = "0x4013F0C")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView AirdropList;

	[Token(Token = "0x4013F0D")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid AirdropGrid;

	[Token(Token = "0x4013F0E")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Player;

	[Token(Token = "0x4013F0F")]
	[FieldOffset(Offset = "0x40")]
	public UIScrollView PlayerList;

	[Token(Token = "0x4013F10")]
	[FieldOffset(Offset = "0x44")]
	public UIEasyList PlayerGrid;

	[Token(Token = "0x4013F11")]
	[FieldOffset(Offset = "0x48")]
	public GameObject PCBG;

	[Token(Token = "0x4013F12")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject MobileBG;

	[Token(Token = "0x4013F13")]
	[FieldOffset(Offset = "0x50")]
	public GameObject GlassBG;

	[Token(Token = "0x6015F6E")]
	[Address(RVA = "0x14098F8", Offset = "0x14098F8", VA = "0x14098F8")]
	public UIBaseHudInfoListView()
	{
	}
}
