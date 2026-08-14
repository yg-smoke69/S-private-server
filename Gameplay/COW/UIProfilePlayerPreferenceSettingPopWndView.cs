using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200392D")]
public class UIProfilePlayerPreferenceSettingPopWndView : UIBaseView
{
	[Token(Token = "0x4017DA1")]
	[FieldOffset(Offset = "0x14")]
	public UITable TableToggle;

	[Token(Token = "0x4017DA2")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButton BasicSetting;

	[Token(Token = "0x4017DA3")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton TagShow;

	[Token(Token = "0x4017DA4")]
	[FieldOffset(Offset = "0x20")]
	public UIToggleButton PregameInfo;

	[Token(Token = "0x4017DA5")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteRedDot;

	[Token(Token = "0x4017DA6")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton PrivateSetting;

	[Token(Token = "0x4017DA7")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BasicSettingPanel;

	[Token(Token = "0x4017DA8")]
	[FieldOffset(Offset = "0x30")]
	public UILabel NameLabel;

	[Token(Token = "0x4017DA9")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ChangeNameBtn;

	[Token(Token = "0x4017DAA")]
	[FieldOffset(Offset = "0x38")]
	public UISprite LanguageSprite;

	[Token(Token = "0x4017DAB")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ChangeLanguageBtn;

	[Token(Token = "0x4017DAC")]
	[FieldOffset(Offset = "0x40")]
	public Transform Sex;

	[Token(Token = "0x4017DAD")]
	[FieldOffset(Offset = "0x44")]
	public Transform DefaultShow;

	[Token(Token = "0x4017DAE")]
	[FieldOffset(Offset = "0x48")]
	public Transform OnLineTime;

	[Token(Token = "0x4017DAF")]
	[FieldOffset(Offset = "0x4C")]
	public Transform ActiveTime;

	[Token(Token = "0x4017DB0")]
	[FieldOffset(Offset = "0x50")]
	public Transform ModePrefer;

	[Token(Token = "0x4017DB1")]
	[FieldOffset(Offset = "0x54")]
	public UIInput InputField;

	[Token(Token = "0x4017DB2")]
	[FieldOffset(Offset = "0x58")]
	public BoxCollider InputFieldCollider;

	[Token(Token = "0x4017DB3")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel SignatureLabel;

	[Token(Token = "0x4017DB4")]
	[FieldOffset(Offset = "0x60")]
	public GameObject TagShowPanel;

	[Token(Token = "0x4017DB5")]
	[FieldOffset(Offset = "0x64")]
	public UIToggleButton BattleToggleBtn;

	[Token(Token = "0x4017DB6")]
	[FieldOffset(Offset = "0x68")]
	public UILabel BattleLabel1;

	[Token(Token = "0x4017DB7")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel BattleTotoalCount;

	[Token(Token = "0x4017DB8")]
	[FieldOffset(Offset = "0x70")]
	public UILabel BattleAcquireConditionsDesc;

	[Token(Token = "0x4017DB9")]
	[FieldOffset(Offset = "0x74")]
	public UIButton LevelReviewTipsBtn;

	[Token(Token = "0x4017DBA")]
	[FieldOffset(Offset = "0x78")]
	public UIGrid Grid;

	[Token(Token = "0x4017DBB")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel LevelConditionNum1;

	[Token(Token = "0x4017DBC")]
	[FieldOffset(Offset = "0x80")]
	public UILabel LevelConditionNum2;

	[Token(Token = "0x4017DBD")]
	[FieldOffset(Offset = "0x84")]
	public UILabel LevelConditionNum3;

	[Token(Token = "0x4017DBE")]
	[FieldOffset(Offset = "0x88")]
	public UILabel LevelConditionNum4;

	[Token(Token = "0x4017DBF")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject BattleUnConfirmBtn1;

	[Token(Token = "0x4017DC0")]
	[FieldOffset(Offset = "0x90")]
	public UIButton BattleUnConfirmBtn;

	[Token(Token = "0x4017DC1")]
	[FieldOffset(Offset = "0x94")]
	public GameObject BattleConfirmBtn1;

	[Token(Token = "0x4017DC2")]
	[FieldOffset(Offset = "0x98")]
	public UIButton BattleConfirmBtn;

	[Token(Token = "0x4017DC3")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject LevelConditionUnLock;

	[Token(Token = "0x4017DC4")]
	[FieldOffset(Offset = "0xA0")]
	public UIGrid BattleTagGrid;

	[Token(Token = "0x4017DC5")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel BattleLabel2;

	[Token(Token = "0x4017DC6")]
	[FieldOffset(Offset = "0xA8")]
	public UIToggleButton SocialToggleBtn;

	[Token(Token = "0x4017DC7")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject SocialConfirmBtn1;

	[Token(Token = "0x4017DC8")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton SocialConfirmBtn;

	[Token(Token = "0x4017DC9")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel SocialDescLabel;

	[Token(Token = "0x4017DCA")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject SocialUnConfirmBtn1;

	[Token(Token = "0x4017DCB")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton SocialUnConfirmBtn;

	[Token(Token = "0x4017DCC")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel SocialLabel1;

	[Token(Token = "0x4017DCD")]
	[FieldOffset(Offset = "0xC4")]
	public UIGrid SocialTagGrid;

	[Token(Token = "0x4017DCE")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel SocialLabel2;

	[Token(Token = "0x4017DCF")]
	[FieldOffset(Offset = "0xCC")]
	public UIToggleButtonGroup PregameInfoPanel;

	[Token(Token = "0x4017DD0")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject WidgetPregameInfo_Preview;

	[Token(Token = "0x4017DD1")]
	[FieldOffset(Offset = "0xD4")]
	public Transform RootPlayerInfoPreview;

	[Token(Token = "0x4017DD2")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel LabelTitlePregameInfoData;

	[Token(Token = "0x4017DD3")]
	[FieldOffset(Offset = "0xDC")]
	public UITable TablePregameInfoData;

	[Token(Token = "0x4017DD4")]
	[FieldOffset(Offset = "0xE0")]
	public UIToggleButtonGroup PrivateSettingPanel;

	[Token(Token = "0x4017DD5")]
	[FieldOffset(Offset = "0xE4")]
	public UITable TablePrivatePanel;

	[Token(Token = "0x4017DD6")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject GoPrivateDisplay;

	[Token(Token = "0x4017DD7")]
	[FieldOffset(Offset = "0xEC")]
	public UIToggleButton PublicToggle;

	[Token(Token = "0x4017DD8")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite PublicToggleWigit;

	[Token(Token = "0x4017DD9")]
	[FieldOffset(Offset = "0xF4")]
	public UIToggleButton PrivateToggle;

	[Token(Token = "0x4017DDA")]
	[FieldOffset(Offset = "0xF8")]
	public UISprite PrivateToggleWigit;

	[Token(Token = "0x6016F2E")]
	[Address(RVA = "0x1AB2118", Offset = "0x1AB2118", VA = "0x1AB2118")]
	public UIProfilePlayerPreferenceSettingPopWndView()
	{
	}

	[Token(Token = "0x6016F2F")]
	[Address(RVA = "0x1AB2120", Offset = "0x1AB2120", VA = "0x1AB2120", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F30")]
	[Address(RVA = "0x1AB36CC", Offset = "0x1AB36CC", VA = "0x1AB36CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
