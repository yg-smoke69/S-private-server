using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038CA")]
public class UINewVaultCommonItemView : UIBaseView
{
	[Token(Token = "0x4017879")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x401787A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject effectBg;

	[Token(Token = "0x401787B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TipsGO;

	[Token(Token = "0x401787C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TagLabel;

	[Token(Token = "0x401787D")]
	[FieldOffset(Offset = "0x24")]
	public UISprite stateSprite;

	[Token(Token = "0x401787E")]
	[FieldOffset(Offset = "0x28")]
	public UISprite validSprite;

	[Token(Token = "0x401787F")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel valid;

	[Token(Token = "0x4017880")]
	[FieldOffset(Offset = "0x30")]
	public UISprite RankIcon;

	[Token(Token = "0x4017881")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Download;

	[Token(Token = "0x4017882")]
	[FieldOffset(Offset = "0x38")]
	public GameObject NormalContainer;

	[Token(Token = "0x4017883")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject expiretag;

	[Token(Token = "0x4017884")]
	[FieldOffset(Offset = "0x40")]
	public UILabel state;

	[Token(Token = "0x4017885")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Descargar;

	[Token(Token = "0x4017886")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ClothRankIcon;

	[Token(Token = "0x4017887")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton DownloadBtn;

	[Token(Token = "0x4017888")]
	[FieldOffset(Offset = "0x50")]
	public GameObject OverDueTitle;

	[Token(Token = "0x4017889")]
	[FieldOffset(Offset = "0x54")]
	public GameObject gray;

	[Token(Token = "0x6016E07")]
	[Address(RVA = "0x2C02C04", Offset = "0x2C02C04", VA = "0x2C02C04")]
	public UINewVaultCommonItemView()
	{
	}

	[Token(Token = "0x6016E08")]
	[Address(RVA = "0x2C02C0C", Offset = "0x2C02C0C", VA = "0x2C02C0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E09")]
	[Address(RVA = "0x2C03354", Offset = "0x2C03354", VA = "0x2C03354")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
