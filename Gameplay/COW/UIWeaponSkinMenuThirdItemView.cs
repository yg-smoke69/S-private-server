using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A74")]
public class UIWeaponSkinMenuThirdItemView : UIBaseView
{
	[Token(Token = "0x4018CE6")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemButton;

	[Token(Token = "0x4018CE7")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel PanelGoToMallWeapon;

	[Token(Token = "0x4018CE8")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnGoToMallWeapon;

	[Token(Token = "0x4018CE9")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteBtnGoToMallWeaponBg;

	[Token(Token = "0x4018CEA")]
	[FieldOffset(Offset = "0x24")]
	public Transform TrWeaponDetail;

	[Token(Token = "0x4018CEB")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Quality;

	[Token(Token = "0x4018CEC")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite QualityBG;

	[Token(Token = "0x4018CED")]
	[FieldOffset(Offset = "0x30")]
	public GameObject gray;

	[Token(Token = "0x4018CEE")]
	[FieldOffset(Offset = "0x34")]
	public GameObject effectBg;

	[Token(Token = "0x4018CEF")]
	[FieldOffset(Offset = "0x38")]
	public UISprite WeaponSprite;

	[Token(Token = "0x4018CF0")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject HL;

	[Token(Token = "0x4018CF1")]
	[FieldOffset(Offset = "0x40")]
	public GameObject WL;

	[Token(Token = "0x4018CF2")]
	[FieldOffset(Offset = "0x44")]
	public UISprite stateSprite;

	[Token(Token = "0x4018CF3")]
	[FieldOffset(Offset = "0x48")]
	public UILabel state;

	[Token(Token = "0x4018CF4")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite validSprite;

	[Token(Token = "0x4018CF5")]
	[FieldOffset(Offset = "0x50")]
	public UILabel valid;

	[Token(Token = "0x4018CF6")]
	[FieldOffset(Offset = "0x54")]
	public UISprite descSprite;

	[Token(Token = "0x4018CF7")]
	[FieldOffset(Offset = "0x58")]
	public UILabel description;

	[Token(Token = "0x4018CF8")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject LevelObj;

	[Token(Token = "0x4018CF9")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LevelLabel;

	[Token(Token = "0x4018CFA")]
	[FieldOffset(Offset = "0x64")]
	public UISprite LevelIcon;

	[Token(Token = "0x4018CFB")]
	[FieldOffset(Offset = "0x68")]
	public Transform LevelCommonTr;

	[Token(Token = "0x4018CFC")]
	[FieldOffset(Offset = "0x6C")]
	public Transform LevelLeftTr;

	[Token(Token = "0x4018CFD")]
	[FieldOffset(Offset = "0x70")]
	public GameObject TipsGO;

	[Token(Token = "0x4018CFE")]
	[FieldOffset(Offset = "0x74")]
	public UISprite GrenadeSprite;

	[Token(Token = "0x4018CFF")]
	[FieldOffset(Offset = "0x78")]
	public GameObject DownloadInfo;

	[Token(Token = "0x4018D00")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel NotReadyLabel;

	[Token(Token = "0x4018D01")]
	[FieldOffset(Offset = "0x80")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4018D02")]
	[FieldOffset(Offset = "0x84")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x4018D03")]
	[FieldOffset(Offset = "0x88")]
	public GameObject MutliSelectState;

	[Token(Token = "0x6017302")]
	[Address(RVA = "0x2EE4AB4", Offset = "0x2EE4AB4", VA = "0x2EE4AB4")]
	public UIWeaponSkinMenuThirdItemView()
	{
	}

	[Token(Token = "0x6017303")]
	[Address(RVA = "0x2EE4ABC", Offset = "0x2EE4ABC", VA = "0x2EE4ABC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017304")]
	[Address(RVA = "0x2EE566C", Offset = "0x2EE566C", VA = "0x2EE566C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
