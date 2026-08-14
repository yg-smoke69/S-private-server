using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033EA")]
public class UIBasicSettingView : UIBaseView
{
	[Token(Token = "0x4013F41")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Resotre;

	[Token(Token = "0x4013F42")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnDeleteAccount;

	[Token(Token = "0x4013F43")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton LogOutBtn;

	[Token(Token = "0x4013F44")]
	[FieldOffset(Offset = "0x20")]
	public Transform LogOutBtnTrans;

	[Token(Token = "0x4013F45")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LogOutIcon;

	[Token(Token = "0x4013F46")]
	[FieldOffset(Offset = "0x28")]
	public UIButton ServiceLinkBtn;

	[Token(Token = "0x4013F47")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnPrivacyPolicy;

	[Token(Token = "0x4013F48")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnTermsOfService;

	[Token(Token = "0x4013F49")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView SettingScrollView;

	[Token(Token = "0x4013F4A")]
	[FieldOffset(Offset = "0x38")]
	public UITable Table;

	[Token(Token = "0x4013F4B")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Account;

	[Token(Token = "0x4013F4C")]
	[FieldOffset(Offset = "0x40")]
	public UILabel BindLabel;

	[Token(Token = "0x4013F4D")]
	[FieldOffset(Offset = "0x44")]
	public UISprite BindIcon;

	[Token(Token = "0x4013F4E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject NotBindLabel;

	[Token(Token = "0x4013F4F")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SecondaryContainer;

	[Token(Token = "0x4013F50")]
	[FieldOffset(Offset = "0x50")]
	public UIButton AccountTipBtn;

	[Token(Token = "0x4013F51")]
	[FieldOffset(Offset = "0x54")]
	public UIGrid AccountBtnCenter;

	[Token(Token = "0x4013F52")]
	[FieldOffset(Offset = "0x58")]
	public UIButton LanPopMenuBtn;

	[Token(Token = "0x4013F53")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite LanMenuWidget;

	[Token(Token = "0x4013F54")]
	[FieldOffset(Offset = "0x60")]
	public UISprite SelectedLan;

	[Token(Token = "0x4013F55")]
	[FieldOffset(Offset = "0x64")]
	public GameObject CanClickHL;

	[Token(Token = "0x4013F56")]
	[FieldOffset(Offset = "0x68")]
	public UIButton SyncSettingTip;

	[Token(Token = "0x4013F57")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton BtnUpload;

	[Token(Token = "0x4013F58")]
	[FieldOffset(Offset = "0x70")]
	public UIButton BtnDownload;

	[Token(Token = "0x4013F59")]
	[FieldOffset(Offset = "0x74")]
	public GameObject WebViewWidget;

	[Token(Token = "0x4013F5A")]
	[FieldOffset(Offset = "0x78")]
	public UIButton BtnWebViewClearCache;

	[Token(Token = "0x4013F5B")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject NetworkReportWidget;

	[Token(Token = "0x4013F5C")]
	[FieldOffset(Offset = "0x80")]
	public UIButton BtnSendReport;

	[Token(Token = "0x4013F5D")]
	[FieldOffset(Offset = "0x84")]
	public GameObject ReportingWidget;

	[Token(Token = "0x4013F5E")]
	[FieldOffset(Offset = "0x88")]
	public UILabel ReportLabel;

	[Token(Token = "0x4013F5F")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject ReportCircle;

	[Token(Token = "0x4013F60")]
	[FieldOffset(Offset = "0x90")]
	public UIButton NetworkReportTip;

	[Token(Token = "0x4013F61")]
	[FieldOffset(Offset = "0x94")]
	public GameObject ChatBlockWidget;

	[Token(Token = "0x4013F62")]
	[FieldOffset(Offset = "0x98")]
	public UIButton BtnChatBlock;

	[Token(Token = "0x4013F63")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject AntiAddictSettingWidget;

	[Token(Token = "0x4013F64")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject NormalAgeGroup;

	[Token(Token = "0x4013F65")]
	[FieldOffset(Offset = "0xA4")]
	public UIToggleButton ToggleChild1;

	[Token(Token = "0x4013F66")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel ToggleChild1SelectLabel;

	[Token(Token = "0x4013F67")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel ToggleChild1UnselectLabel;

	[Token(Token = "0x4013F68")]
	[FieldOffset(Offset = "0xB0")]
	public UIToggleButton ToggleAdult1;

	[Token(Token = "0x4013F69")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel ToggleAdult1SelectLabel;

	[Token(Token = "0x4013F6A")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel ToggleAdult1UnselectLabel;

	[Token(Token = "0x4013F6B")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject ChildrenAgeGroup;

	[Token(Token = "0x4013F6C")]
	[FieldOffset(Offset = "0xC0")]
	public UIToggleButton ToggleChild2;

	[Token(Token = "0x4013F6D")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel ToggleChild2SelectLabel;

	[Token(Token = "0x4013F6E")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel ToggleChild2UnselectLabel;

	[Token(Token = "0x4013F6F")]
	[FieldOffset(Offset = "0xCC")]
	public UIToggleButton ToggleTeenage2;

	[Token(Token = "0x4013F70")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel ToggleTeenage2SelectLabel;

	[Token(Token = "0x4013F71")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel ToggleTeenage2UnselectLabel;

	[Token(Token = "0x4013F72")]
	[FieldOffset(Offset = "0xD8")]
	public UIToggleButton ToggleAdult2;

	[Token(Token = "0x4013F73")]
	[FieldOffset(Offset = "0xDC")]
	public UILabel ToggleAdult2SelectLabel;

	[Token(Token = "0x4013F74")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel ToggleAdult2UnselectLabel;

	[Token(Token = "0x4013F75")]
	[FieldOffset(Offset = "0xE4")]
	public Transform AccountRestoreContainer;

	[Token(Token = "0x6015F72")]
	[Address(RVA = "0x1411914", Offset = "0x1411914", VA = "0x1411914")]
	public UIBasicSettingView()
	{
	}

	[Token(Token = "0x6015F73")]
	[Address(RVA = "0x141191C", Offset = "0x141191C", VA = "0x141191C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F74")]
	[Address(RVA = "0x1412D58", Offset = "0x1412D58", VA = "0x1412D58")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
