using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037D3")]
public class UIHUDWereWolvesMatchResultView : UIBaseView
{
	[Token(Token = "0x4016A34")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RewardRoot;

	[Token(Token = "0x4016A35")]
	[FieldOffset(Offset = "0x18")]
	public UITable RewardTabel;

	[Token(Token = "0x4016A36")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GoldCount;

	[Token(Token = "0x4016A37")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ExpCount;

	[Token(Token = "0x4016A38")]
	[FieldOffset(Offset = "0x24")]
	public UISprite PetExpIcon;

	[Token(Token = "0x4016A39")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PetExpCount;

	[Token(Token = "0x4016A3A")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ShareBtn;

	[Token(Token = "0x4016A3B")]
	[FieldOffset(Offset = "0x30")]
	public UIButton QuitBtn;

	[Token(Token = "0x4016A3C")]
	[FieldOffset(Offset = "0x34")]
	public UILabel QuitTimeLabel;

	[Token(Token = "0x4016A3D")]
	[FieldOffset(Offset = "0x38")]
	public UIHUDWereWolvesPlayerResultItem PlayerInfoTemplate;

	[Token(Token = "0x4016A3E")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject WinRoot;

	[Token(Token = "0x4016A3F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject DefeatRoot;

	[Token(Token = "0x4016A40")]
	[FieldOffset(Offset = "0x44")]
	public GameObject WolfRolIconRoot;

	[Token(Token = "0x4016A41")]
	[FieldOffset(Offset = "0x48")]
	public GameObject WolfRoleWinIcon;

	[Token(Token = "0x4016A42")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject WolfRoleDefeatIcon;

	[Token(Token = "0x4016A43")]
	[FieldOffset(Offset = "0x50")]
	public GameObject HumanRoleIconRoot;

	[Token(Token = "0x4016A44")]
	[FieldOffset(Offset = "0x54")]
	public GameObject HumanRoleWinIcon;

	[Token(Token = "0x4016A45")]
	[FieldOffset(Offset = "0x58")]
	public GameObject HumanRoleDefeatIcon;

	[Token(Token = "0x4016A46")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel GameOverReasonLabel;

	[Token(Token = "0x4016A47")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid LeftDataGrid;

	[Token(Token = "0x4016A48")]
	[FieldOffset(Offset = "0x64")]
	public UIGrid RightDataGrid;

	[Token(Token = "0x4016A49")]
	[FieldOffset(Offset = "0x68")]
	public UIEasyList ChatEasyList;

	[Token(Token = "0x4016A4A")]
	[FieldOffset(Offset = "0x6C")]
	public UIInput ChatInput;

	[Token(Token = "0x4016A4B")]
	[FieldOffset(Offset = "0x70")]
	public UIButton BtnSendChat;

	[Token(Token = "0x4016A4C")]
	[FieldOffset(Offset = "0x74")]
	public UIButton BtnVoice;

	[Token(Token = "0x4016A4D")]
	[FieldOffset(Offset = "0x78")]
	public GameObject VoiceOn;

	[Token(Token = "0x4016A4E")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject VoiceOff;

	[Token(Token = "0x4016A4F")]
	[FieldOffset(Offset = "0x80")]
	public GameObject MicBan;

	[Token(Token = "0x6016B24")]
	[Address(RVA = "0x1625250", Offset = "0x1625250", VA = "0x1625250")]
	public UIHUDWereWolvesMatchResultView()
	{
	}

	[Token(Token = "0x6016B25")]
	[Address(RVA = "0x1625258", Offset = "0x1625258", VA = "0x1625258", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B26")]
	[Address(RVA = "0x1625D90", Offset = "0x1625D90", VA = "0x1625D90")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
