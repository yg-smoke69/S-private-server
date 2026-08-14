using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using GarenaMSDK;
using Il2CppDummyDll;

[Token(Token = "0x2002372")]
public class UIBasicSettingController : UISettingContentBase, _Attribute
{
	[Token(Token = "0x2002373")]
	private enum Block
	{
		[Token(Token = "0x400DCBC")]
		AccountRestoreAndBackUp
	}

	[Token(Token = "0x2002374")]
	private enum BasicSettingKey
	{
		[Token(Token = "0x400DCBE")]
		AntiAddict,
		[Token(Token = "0x400DCBF")]
		AccountRestore,
		[Token(Token = "0x400DCC0")]
		AccountBackUp
	}

	[Token(Token = "0x2002375")]
	private sealed class _003COnBtnDeleteAccountClick_003Ec__AnonStorey2
	{
		[Token(Token = "0x400DCC1")]
		[FieldOffset(Offset = "0x8")]
		internal UISecondConfirmContoller confirmWnd;

		[Token(Token = "0x600C660")]
		[Address(RVA = "0x26518FC", Offset = "0x26518FC", VA = "0x26518FC")]
		public _003COnBtnDeleteAccountClick_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600C661")]
		[Address(RVA = "0x2655150", Offset = "0x2655150", VA = "0x2655150")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002376")]
	private sealed class _003CRefreshScroll_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DCC2")]
		[FieldOffset(Offset = "0x8")]
		internal UIBasicSettingController _0024this;

		[Token(Token = "0x400DCC3")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DCC4")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DCC5")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010D6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C664")]
			[Address(RVA = "0x2655474", Offset = "0x2655474", VA = "0x2655474", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010D7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C665")]
			[Address(RVA = "0x265547C", Offset = "0x265547C", VA = "0x265547C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C662")]
		[Address(RVA = "0x26519B8", Offset = "0x26519B8", VA = "0x26519B8")]
		public _003CRefreshScroll_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C663")]
		[Address(RVA = "0x2655368", Offset = "0x2655368", VA = "0x2655368", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C666")]
		[Address(RVA = "0x2655484", Offset = "0x2655484", VA = "0x2655484", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C667")]
		[Address(RVA = "0x2655498", Offset = "0x2655498", VA = "0x2655498", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002377")]
	private sealed class _003CInitBindAccountSetting_003Ec__AnonStorey3
	{
		[Token(Token = "0x400DCC6")]
		[FieldOffset(Offset = "0x8")]
		internal string tip;

		[Token(Token = "0x600C668")]
		[Address(RVA = "0x2652684", Offset = "0x2652684", VA = "0x2652684")]
		public _003CInitBindAccountSetting_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600C669")]
		[Address(RVA = "0x2654FCC", Offset = "0x2654FCC", VA = "0x2654FCC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002378")]
	private sealed class _003CRestoreCoroutine_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DCC7")]
		[FieldOffset(Offset = "0x8")]
		internal UIBasicSettingController _0024this;

		[Token(Token = "0x400DCC8")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DCC9")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DCCA")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010D8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C66C")]
			[Address(RVA = "0x26557F4", Offset = "0x26557F4", VA = "0x26557F4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010D9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C66D")]
			[Address(RVA = "0x26557FC", Offset = "0x26557FC", VA = "0x26557FC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C66A")]
		[Address(RVA = "0x2654284", Offset = "0x2654284", VA = "0x2654284")]
		public _003CRestoreCoroutine_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600C66B")]
		[Address(RVA = "0x2655520", Offset = "0x2655520", VA = "0x2655520", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C66E")]
		[Address(RVA = "0x2655804", Offset = "0x2655804", VA = "0x2655804", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C66F")]
		[Address(RVA = "0x2655818", Offset = "0x2655818", VA = "0x2655818", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DCA4")]
	private const int TOGGLE_GROUP_ID = 117;

	[Token(Token = "0x400DCA5")]
	[FieldOffset(Offset = "0x2C")]
	private UIBasicSettingView m_View;

	[Token(Token = "0x400DCA6")]
	[FieldOffset(Offset = "0x30")]
	private UIModelSetting m_Model;

	[Token(Token = "0x400DCA7")]
	[FieldOffset(Offset = "0x34")]
	private UIModelConnectionReport m_ConnectionModel;

	[Token(Token = "0x400DCA8")]
	[FieldOffset(Offset = "0x38")]
	private UIButton[] m_HideIngameGO;

	[Token(Token = "0x400DCA9")]
	[FieldOffset(Offset = "0x3C")]
	private List<PopMenuData> m_LanDataList;

	[Token(Token = "0x400DCAA")]
	[FieldOffset(Offset = "0x40")]
	private List<UISettingAccountBtnController> m_AccountBtnList;

	[Token(Token = "0x400DCAB")]
	[FieldOffset(Offset = "0x44")]
	private UIModelLogin m_LoginModel;

	[Token(Token = "0x400DCAC")]
	[FieldOffset(Offset = "0x48")]
	private BasicSettingInfo m_SettingInfo;

	[Token(Token = "0x400DCAD")]
	[FieldOffset(Offset = "0x4C")]
	private UISelectLanguageController m_UISelectLanguageController;

	[Token(Token = "0x400DCAE")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<int, bool> m_PlatformSupportSignin;

	[Token(Token = "0x400DCAF")]
	[FieldOffset(Offset = "0x54")]
	private bool m_NeedRefreshBtnState;

	[Token(Token = "0x400DCB0")]
	[FieldOffset(Offset = "0x58")]
	private UIModelUser m_UserModel;

	[Token(Token = "0x400DCB1")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelAntiAddiction m_AntiAddictionModel;

	[Token(Token = "0x400DCB2")]
	[FieldOffset(Offset = "0x60")]
	private List<UICommonSettingContentController> m_CtrlList;

	[Token(Token = "0x400DCB3")]
	[FieldOffset(Offset = "0x64")]
	private List<CommonSettingContentData> m_DataList;

	[Token(Token = "0x400DCB4")]
	[FieldOffset(Offset = "0x68")]
	private UISyncSettingConfirmController m_Ctrl;

	[Token(Token = "0x400DCB5")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400DCB6")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400DCB7")]
	[FieldOffset(Offset = "0x8")]
	private static Callback _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x400DCB8")]
	[FieldOffset(Offset = "0xC")]
	private static Func<int> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400DCB9")]
	[FieldOffset(Offset = "0x10")]
	private static Func<int> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400DCBA")]
	[FieldOffset(Offset = "0x14")]
	private static Action _003C_003Ef__am_0024cache4;

	[Token(Token = "0x170010D5")]
	private UIModelConnectionReport ConnectionModel
	{
		[Token(Token = "0x600C61B")]
		[Address(RVA = "0x264C7C0", Offset = "0x264C7C0", VA = "0x264C7C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600C61A")]
	[Address(RVA = "0x264C690", Offset = "0x264C690", VA = "0x264C690")]
	public UIBasicSettingController()
	{
	}

	[Token(Token = "0x600C61C")]
	[Address(RVA = "0x264C888", Offset = "0x264C888", VA = "0x264C888", Slot = "31")]
	public override void SetInGameShow(bool isInGame)
	{
	}

	[Token(Token = "0x600C61D")]
	[Address(RVA = "0x264C938", Offset = "0x264C938", VA = "0x264C938")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C61E")]
	[Address(RVA = "0x264C9A0", Offset = "0x264C9A0", VA = "0x264C9A0", Slot = "32")]
	protected override void InitSettingInfo()
	{
	}

	[Token(Token = "0x600C61F")]
	[Address(RVA = "0x264CAB0", Offset = "0x264CAB0", VA = "0x264CAB0", Slot = "33")]
	public override void RefreshContent(object[] param)
	{
	}

	[Token(Token = "0x600C620")]
	[Address(RVA = "0x264CCC4", Offset = "0x264CCC4", VA = "0x264CCC4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C621")]
	[Address(RVA = "0x264D0B8", Offset = "0x264D0B8", VA = "0x264D0B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C622")]
	[Address(RVA = "0x264E85C", Offset = "0x264E85C", VA = "0x264E85C")]
	protected void InitAntiAddictSettingView()
	{
	}

	[Token(Token = "0x600C623")]
	[Address(RVA = "0x2650FA0", Offset = "0x2650FA0", VA = "0x2650FA0")]
	protected void OnBtnChildClick()
	{
	}

	[Token(Token = "0x600C624")]
	[Address(RVA = "0x2650FD0", Offset = "0x2650FD0", VA = "0x2650FD0")]
	protected void OnBtnTeenageClick()
	{
	}

	[Token(Token = "0x600C625")]
	[Address(RVA = "0x2651000", Offset = "0x2651000", VA = "0x2651000")]
	protected void OnBtnAdultClick()
	{
	}

	[Token(Token = "0x600C626")]
	[Address(RVA = "0x2651030", Offset = "0x2651030", VA = "0x2651030")]
	private void SendSetAgeStateReq()
	{
	}

	[Token(Token = "0x600C627")]
	[Address(RVA = "0x265125C", Offset = "0x265125C", VA = "0x265125C")]
	public void OnBtnDeleteAccountClick()
	{
	}

	[Token(Token = "0x600C628")]
	[Address(RVA = "0x2651904", Offset = "0x2651904", VA = "0x2651904", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C629")]
	[Address(RVA = "0x2651934", Offset = "0x2651934", VA = "0x2651934")]
	private IEnumerator RefreshScroll()
	{
		return null;
	}

	[Token(Token = "0x600C62A")]
	[Address(RVA = "0x2650DD4", Offset = "0x2650DD4", VA = "0x2650DD4")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x600C62B")]
	[Address(RVA = "0x26519C0", Offset = "0x26519C0", VA = "0x26519C0")]
	public void SetPopupWnd(UIModelSetting.SyncStatus status)
	{
	}

	[Token(Token = "0x600C62C")]
	[Address(RVA = "0x2651B1C", Offset = "0x2651B1C", VA = "0x2651B1C")]
	public void UploadSetting()
	{
	}

	[Token(Token = "0x600C62D")]
	[Address(RVA = "0x2651B48", Offset = "0x2651B48", VA = "0x2651B48")]
	private void OnChatBlockClick()
	{
	}

	[Token(Token = "0x600C62E")]
	[Address(RVA = "0x2651C0C", Offset = "0x2651C0C", VA = "0x2651C0C")]
	private void OnWebViewClearCacheClick()
	{
	}

	[Token(Token = "0x600C62F")]
	[Address(RVA = "0x2651FB4", Offset = "0x2651FB4", VA = "0x2651FB4")]
	private void OnBtnSendNetworkReportClick()
	{
	}

	[Token(Token = "0x600C630")]
	[Address(RVA = "0x2650A28", Offset = "0x2650A28", VA = "0x2650A28")]
	private void RefreshNetworkReportBtnState(bool reset_to_default = false)
	{
	}

	[Token(Token = "0x600C631")]
	[Address(RVA = "0x2651FF0", Offset = "0x2651FF0", VA = "0x2651FF0")]
	private void OnDownloadClick()
	{
	}

	[Token(Token = "0x600C632")]
	[Address(RVA = "0x265201C", Offset = "0x265201C", VA = "0x265201C")]
	private void OnUploadClick()
	{
	}

	[Token(Token = "0x600C633")]
	[Address(RVA = "0x26520A0", Offset = "0x26520A0", VA = "0x26520A0")]
	private void OnSyncSettingTipClick()
	{
	}

	[Token(Token = "0x600C634")]
	[Address(RVA = "0x26522B0", Offset = "0x26522B0", VA = "0x26522B0")]
	private void OnNetworkReportTipClick()
	{
	}

	[Token(Token = "0x600C635")]
	[Address(RVA = "0x264E2EC", Offset = "0x264E2EC", VA = "0x264E2EC")]
	private void InitBindPlatformDict()
	{
	}

	[Token(Token = "0x600C636")]
	[Address(RVA = "0x26524C0", Offset = "0x26524C0", VA = "0x26524C0")]
	private void CheckPlatformBtnState(PlatformType platformType)
	{
	}

	[Token(Token = "0x600C637")]
	[Address(RVA = "0x26525C4", Offset = "0x26525C4", VA = "0x26525C4")]
	private bool CheckPlatformBindBtnCanShow(PlatformType platformType)
	{
		return default(bool);
	}

	[Token(Token = "0x600C638")]
	[Address(RVA = "0x264DE9C", Offset = "0x264DE9C", VA = "0x264DE9C")]
	private void SetSecondaryShow()
	{
	}

	[Token(Token = "0x600C639")]
	[Address(RVA = "0x264F22C", Offset = "0x264F22C", VA = "0x264F22C")]
	private void InitBindAccountSetting(SDKBind.PlatformBindingInfo info)
	{
	}

	[Token(Token = "0x600C63A")]
	[Address(RVA = "0x265080C", Offset = "0x265080C", VA = "0x265080C")]
	private bool ShouldShowCustomService()
	{
		return default(bool);
	}

	[Token(Token = "0x600C63B")]
	[Address(RVA = "0x2650A20", Offset = "0x2650A20", VA = "0x2650A20")]
	private bool ShouldShowDeleteAccountBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x600C63C")]
	[Address(RVA = "0x264E44C", Offset = "0x264E44C", VA = "0x264E44C")]
	private void InitBtnClickDelegete()
	{
	}

	[Token(Token = "0x600C63D")]
	[Address(RVA = "0x264E34C", Offset = "0x264E34C", VA = "0x264E34C")]
	private void InitLanguageSetting()
	{
	}

	[Token(Token = "0x600C63E")]
	[Address(RVA = "0x265268C", Offset = "0x265268C", VA = "0x265268C")]
	private void InitLanguageList()
	{
	}

	[Token(Token = "0x600C63F")]
	[Address(RVA = "0x26529B0", Offset = "0x26529B0", VA = "0x26529B0")]
	public void ConfirmSetLan(object[] data)
	{
	}

	[Token(Token = "0x600C640")]
	[Address(RVA = "0x2652C24", Offset = "0x2652C24", VA = "0x2652C24")]
	private CommonSettingItemDataToggleBtns CreateAntiAddictSettingData()
	{
		return null;
	}

	[Token(Token = "0x600C641")]
	[Address(RVA = "0x2652C90", Offset = "0x2652C90", VA = "0x2652C90")]
	private void OnAntiAddictSettingClick(bool value)
	{
	}

	[Token(Token = "0x600C642")]
	[Address(RVA = "0x2652C94", Offset = "0x2652C94", VA = "0x2652C94")]
	private CommonSettingContentData CreateBlock2Data()
	{
		return null;
	}

	[Token(Token = "0x600C643")]
	[Address(RVA = "0x2652D00", Offset = "0x2652D00", VA = "0x2652D00")]
	private int GetAntiAddictSettingSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C644")]
	[Address(RVA = "0x2652D80", Offset = "0x2652D80", VA = "0x2652D80")]
	private CommonSettingItemDataToggleBtns CreateAccountRestoreData()
	{
		return null;
	}

	[Token(Token = "0x600C645")]
	[Address(RVA = "0x2653028", Offset = "0x2653028", VA = "0x2653028")]
	private void OnAccountRestoreTipClick()
	{
	}

	[Token(Token = "0x600C646")]
	[Address(RVA = "0x2653238", Offset = "0x2653238", VA = "0x2653238")]
	private CommonSettingItemDataToggleBtns CreateAccountBackUpData()
	{
		return null;
	}

	[Token(Token = "0x600C647")]
	[Address(RVA = "0x26534DC", Offset = "0x26534DC", VA = "0x26534DC")]
	private void OnAccountBackUpTipClick()
	{
	}

	[Token(Token = "0x600C648")]
	[Address(RVA = "0x26536EC", Offset = "0x26536EC", VA = "0x26536EC")]
	private void OnBtnAccountRestoreClick()
	{
	}

	[Token(Token = "0x600C649")]
	[Address(RVA = "0x265395C", Offset = "0x265395C", VA = "0x265395C")]
	private void RefreshAccountRestoreAndBackUpContainer()
	{
	}

	[Token(Token = "0x600C64A")]
	[Address(RVA = "0x2653BC0", Offset = "0x2653BC0", VA = "0x2653BC0")]
	private void OnBtnAccountBackUpClick()
	{
	}

	[Token(Token = "0x600C64B")]
	[Address(RVA = "0x2650C80", Offset = "0x2650C80", VA = "0x2650C80")]
	private CommonSettingContentData CreateAccountRestoreAndBackUpBlockData()
	{
		return null;
	}

	[Token(Token = "0x600C64C")]
	[Address(RVA = "0x2653DF8", Offset = "0x2653DF8", VA = "0x2653DF8")]
	private void onBtnTermsOfServiceClick()
	{
	}

	[Token(Token = "0x600C64D")]
	[Address(RVA = "0x2653E74", Offset = "0x2653E74", VA = "0x2653E74")]
	private void onBtnPrivacyPolicyClick()
	{
	}

	[Token(Token = "0x600C64E")]
	[Address(RVA = "0x2653EF0", Offset = "0x2653EF0", VA = "0x2653EF0")]
	private void OnLanPopMenuBtnClick()
	{
	}

	[Token(Token = "0x600C64F")]
	[Address(RVA = "0x2654018", Offset = "0x2654018", VA = "0x2654018")]
	private void OnLogoutBtnClick()
	{
	}

	[Token(Token = "0x600C650")]
	[Address(RVA = "0x26541DC", Offset = "0x26541DC", VA = "0x26541DC")]
	private void OnRestoreBtnClick()
	{
	}

	[Token(Token = "0x600C651")]
	[Address(RVA = "0x2654200", Offset = "0x2654200", VA = "0x2654200")]
	private IEnumerator RestoreCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600C652")]
	[Address(RVA = "0x265428C", Offset = "0x265428C", VA = "0x265428C", Slot = "34")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600C653")]
	[Address(RVA = "0x265483C", Offset = "0x265483C", VA = "0x265483C", Slot = "35")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600C654")]
	[Address(RVA = "0x264CB30", Offset = "0x264CB30", VA = "0x264CB30")]
	private void RefreshBtnsState(object[] param)
	{
	}

	[Token(Token = "0x600C655")]
	[Address(RVA = "0x26548C8", Offset = "0x26548C8", VA = "0x26548C8")]
	private void _003CSendSetAgeStateReq_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x600C656")]
	[Address(RVA = "0x265492C", Offset = "0x265492C", VA = "0x265492C")]
	private static void _003COnBtnDeleteAccountClick_003Em__1()
	{
	}

	[Token(Token = "0x600C657")]
	[Address(RVA = "0x2654B54", Offset = "0x2654B54", VA = "0x2654B54")]
	private static void _003COnWebViewClearCacheClick_003Em__2()
	{
	}

	[Token(Token = "0x600C658")]
	[Address(RVA = "0x2654DA0", Offset = "0x2654DA0", VA = "0x2654DA0")]
	private void _003CInitLanguageList_003Em__3(object lan)
	{
	}

	[Token(Token = "0x600C659")]
	[Address(RVA = "0x2654E74", Offset = "0x2654E74", VA = "0x2654E74")]
	private void _003CCreateAccountRestoreData_003Em__4()
	{
	}

	[Token(Token = "0x600C65A")]
	[Address(RVA = "0x2654E78", Offset = "0x2654E78", VA = "0x2654E78")]
	private static int _003CCreateAccountRestoreData_003Em__5()
	{
		return default(int);
	}

	[Token(Token = "0x600C65B")]
	[Address(RVA = "0x2654E80", Offset = "0x2654E80", VA = "0x2654E80")]
	private void _003CCreateAccountBackUpData_003Em__6()
	{
	}

	[Token(Token = "0x600C65C")]
	[Address(RVA = "0x2654E84", Offset = "0x2654E84", VA = "0x2654E84")]
	private static int _003CCreateAccountBackUpData_003Em__7()
	{
		return default(int);
	}

	[Token(Token = "0x600C65D")]
	[Address(RVA = "0x2654E8C", Offset = "0x2654E8C", VA = "0x2654E8C")]
	private void _003COnBtnAccountRestoreClick_003Em__8()
	{
	}

	[Token(Token = "0x600C65E")]
	[Address(RVA = "0x2654EC4", Offset = "0x2654EC4", VA = "0x2654EC4")]
	private void _003COnBtnAccountBackUpClick_003Em__9()
	{
	}

	[Token(Token = "0x600C65F")]
	[Address(RVA = "0x2654EF0", Offset = "0x2654EF0", VA = "0x2654EF0")]
	private static void _003COnLogoutBtnClick_003Em__A()
	{
	}
}
