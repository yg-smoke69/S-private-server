using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200398F")]
public class UISceneEditGMVerifyView : UIBaseView
{
	[Token(Token = "0x40181CD")]
	[FieldOffset(Offset = "0x14")]
	public UITable VerifyTable;

	[Token(Token = "0x40181CE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel IndexLabel;

	[Token(Token = "0x40181CF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel curPassedLabel;

	[Token(Token = "0x40181D0")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PassedNumLabel;

	[Token(Token = "0x40181D1")]
	[FieldOffset(Offset = "0x24")]
	public UITable OperateTable;

	[Token(Token = "0x40181D2")]
	[FieldOffset(Offset = "0x28")]
	public UIButton VerifyButton;

	[Token(Token = "0x40181D3")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton DetailsButton;

	[Token(Token = "0x40181D4")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BackButton;

	[Token(Token = "0x40181D5")]
	[FieldOffset(Offset = "0x34")]
	public UITable FileTable;

	[Token(Token = "0x40181D6")]
	[FieldOffset(Offset = "0x38")]
	public UIButton GMPreCodeButton;

	[Token(Token = "0x40181D7")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton WorkshopMapRECButton;

	[Token(Token = "0x40181D8")]
	[FieldOffset(Offset = "0x40")]
	public UIButton WorkshopMapWeekListButton;

	[Token(Token = "0x40181D9")]
	[FieldOffset(Offset = "0x44")]
	public UITable PageTable;

	[Token(Token = "0x40181DA")]
	[FieldOffset(Offset = "0x48")]
	public UIButton PreviousButton;

	[Token(Token = "0x40181DB")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton NextButton;

	[Token(Token = "0x40181DC")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget PopupMenu;

	[Token(Token = "0x40181DD")]
	[FieldOffset(Offset = "0x54")]
	public UIButton OpenPopupButton;

	[Token(Token = "0x40181DE")]
	[FieldOffset(Offset = "0x58")]
	public UILabel SelectItemLabel;

	[Token(Token = "0x40181DF")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject DownArr;

	[Token(Token = "0x40181E0")]
	[FieldOffset(Offset = "0x60")]
	public UITable BatchTable;

	[Token(Token = "0x40181E1")]
	[FieldOffset(Offset = "0x64")]
	public UIButton BatchUnlockSlotsBtn;

	[Token(Token = "0x40181E2")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BatchUploadBtn;

	[Token(Token = "0x40181E3")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel BatchUnlockSlotsLabel;

	[Token(Token = "0x40181E4")]
	[FieldOffset(Offset = "0x70")]
	public UILabel BatchUploadLabel;

	[Token(Token = "0x40181E5")]
	[FieldOffset(Offset = "0x74")]
	public GameObject UISceneEditGMVerify;

	[Token(Token = "0x40181E6")]
	[FieldOffset(Offset = "0x78")]
	public UIWidget VerifyInfoWidget;

	[Token(Token = "0x6017054")]
	[Address(RVA = "0x14ACFEC", Offset = "0x14ACFEC", VA = "0x14ACFEC")]
	public UISceneEditGMVerifyView()
	{
	}

	[Token(Token = "0x6017055")]
	[Address(RVA = "0x14ACFF4", Offset = "0x14ACFF4", VA = "0x14ACFF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017056")]
	[Address(RVA = "0x14ADAE4", Offset = "0x14ADAE4", VA = "0x14ADAE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
