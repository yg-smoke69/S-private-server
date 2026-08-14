using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using GarenaMSDK;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200294E")]
public class UILoginController : UIBaseController, _Attribute
{
	[Token(Token = "0x200294F")]
	private sealed class _003CManualLogin_003Ec__AnonStorey1
	{
		[Token(Token = "0x400FEA9")]
		[FieldOffset(Offset = "0x8")]
		internal PlatformType platformType;

		[Token(Token = "0x601085A")]
		[Address(RVA = "0x21EC900", Offset = "0x21EC900", VA = "0x21EC900")]
		public _003CManualLogin_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601085B")]
		[Address(RVA = "0x21F3AE0", Offset = "0x21F3AE0", VA = "0x21F3AE0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002950")]
	private sealed class _003CSetButtonCoolDown_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FEAA")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x400FEAB")]
		[FieldOffset(Offset = "0xC")]
		internal UIButton btn;

		[Token(Token = "0x400FEAC")]
		[FieldOffset(Offset = "0x10")]
		internal UILoginController _0024this;

		[Token(Token = "0x400FEAD")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400FEAE")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400FEAF")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17001259")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601085E")]
			[Address(RVA = "0x21F3CDC", Offset = "0x21F3CDC", VA = "0x21F3CDC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700125A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601085F")]
			[Address(RVA = "0x21F3CE4", Offset = "0x21F3CE4", VA = "0x21F3CE4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601085C")]
		[Address(RVA = "0x21F2570", Offset = "0x21F2570", VA = "0x21F2570")]
		public _003CSetButtonCoolDown_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601085D")]
		[Address(RVA = "0x21F3BC4", Offset = "0x21F3BC4", VA = "0x21F3BC4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010860")]
		[Address(RVA = "0x21F3CEC", Offset = "0x21F3CEC", VA = "0x21F3CEC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010861")]
		[Address(RVA = "0x21F3D00", Offset = "0x21F3D00", VA = "0x21F3D00", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FE93")]
	public const string ACCOUNTREGION = "ACCOUNTREGION_{0}";

	[Token(Token = "0x400FE94")]
	public const string VNLINKLOG = "LOGINPAGEVNLINKLOG_{0}";

	[Token(Token = "0x400FE95")]
	private const uint VNLinkSee = 1u;

	[Token(Token = "0x400FE96")]
	private const uint VNLinkClick = 2u;

	[Token(Token = "0x400FE97")]
	[FieldOffset(Offset = "0x28")]
	private UILoginView m_View;

	[Token(Token = "0x400FE98")]
	[FieldOffset(Offset = "0x2C")]
	private UIVersionController m_UIVersion;

	[Token(Token = "0x400FE99")]
	[FieldOffset(Offset = "0x30")]
	private bool m_platfromLogined;

	[Token(Token = "0x400FE9A")]
	[FieldOffset(Offset = "0x34")]
	private UIPopupMessageBoxController m_MaintenanceMessageCtrl;

	[Token(Token = "0x400FE9B")]
	[FieldOffset(Offset = "0x38")]
	private uint limitedAge;

	[Token(Token = "0x400FE9C")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_GyroSettingInit;

	[Token(Token = "0x400FE9D")]
	[FieldOffset(Offset = "0x40")]
	private UIGyroMove m_GyroMoveNow;

	[Token(Token = "0x400FE9E")]
	[FieldOffset(Offset = "0x44")]
	private ResourceID m_LoginBGSpine1;

	[Token(Token = "0x400FE9F")]
	[FieldOffset(Offset = "0x48")]
	private ResourceID m_LoginBGSpine2;

	[Token(Token = "0x400FEA0")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject m_SpineBG;

	[Token(Token = "0x400FEA1")]
	[FieldOffset(Offset = "0x50")]
	private ResourceID m_CurrentSpineBGResID;

	[Token(Token = "0x400FEA2")]
	[FieldOffset(Offset = "0x54")]
	private UIRegisterController m_CtrlRegister;

	[Token(Token = "0x400FEA3")]
	[FieldOffset(Offset = "0x58")]
	private bool _AutosaveGuest;

	[Token(Token = "0x400FEA4")]
	[FieldOffset(Offset = "0x59")]
	private bool _RetriedGuestRestore;

	[Token(Token = "0x400FEA5")]
	[FieldOffset(Offset = "0x0")]
	private static SDKLogin.SAFGuestCb _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400FEA6")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400FEA7")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<string, int> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x400FEA8")]
	[FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x6010818")]
	[Address(RVA = "0x21E7208", Offset = "0x21E7208", VA = "0x21E7208")]
	public UILoginController()
	{
	}

	[Token(Token = "0x6010819")]
	[Address(RVA = "0x21E72BC", Offset = "0x21E72BC", VA = "0x21E72BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601081A")]
	[Address(RVA = "0x21E7360", Offset = "0x21E7360", VA = "0x21E7360")]
	private void InitLoginButtons()
	{
	}

	[Token(Token = "0x601081B")]
	[Address(RVA = "0x21E85D8", Offset = "0x21E85D8", VA = "0x21E85D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601081C")]
	[Address(RVA = "0x21EB34C", Offset = "0x21EB34C", VA = "0x21EB34C")]
	private void InitPPTOP()
	{
	}

	[Token(Token = "0x601081D")]
	[Address(RVA = "0x21EBAB4", Offset = "0x21EBAB4", VA = "0x21EBAB4")]
	private void ChangeTOSState(object[] data)
	{
	}

	[Token(Token = "0x601081E")]
	[Address(RVA = "0x21E9FA4", Offset = "0x21E9FA4", VA = "0x21E9FA4")]
	private void InitTOS()
	{
	}

	[Token(Token = "0x601081F")]
	[Address(RVA = "0x21EBB50", Offset = "0x21EBB50", VA = "0x21EBB50")]
	private void UpdateBtnBoxCollider(UIButton button, Vector2 newSize, Vector2 newPos)
	{
	}

	[Token(Token = "0x6010820")]
	[Address(RVA = "0x21EBD0C", Offset = "0x21EBD0C", VA = "0x21EBD0C")]
	private void OnToggleTOSChange()
	{
	}

	[Token(Token = "0x6010821")]
	[Address(RVA = "0x21EC148", Offset = "0x21EC148", VA = "0x21EC148")]
	private void OnBtnServiceClick()
	{
	}

	[Token(Token = "0x6010822")]
	[Address(RVA = "0x21EC264", Offset = "0x21EC264", VA = "0x21EC264")]
	private void OnBtnPrivacyClick()
	{
	}

	[Token(Token = "0x6010823")]
	[Address(RVA = "0x21EABD8", Offset = "0x21EABD8", VA = "0x21EABD8")]
	private void InitAgeCheck()
	{
	}

	[Token(Token = "0x6010824")]
	[Address(RVA = "0x21EA654", Offset = "0x21EA654", VA = "0x21EA654")]
	private void RestorePlatformLogin()
	{
	}

	[Token(Token = "0x6010825")]
	[Address(RVA = "0x21EC380", Offset = "0x21EC380", VA = "0x21EC380")]
	private void AutoLogin(PlatformType platformType)
	{
	}

	[Token(Token = "0x6010826")]
	[Address(RVA = "0x21EC550", Offset = "0x21EC550", VA = "0x21EC550")]
	private void ManualLogin(PlatformType platformType)
	{
	}

	[Token(Token = "0x6010827")]
	[Address(RVA = "0x21EC908", Offset = "0x21EC908", VA = "0x21EC908", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010828")]
	[Address(RVA = "0x21ED0E8", Offset = "0x21ED0E8", VA = "0x21ED0E8")]
	private void OnServerChanged()
	{
	}

	[Token(Token = "0x6010829")]
	[Address(RVA = "0x21ED29C", Offset = "0x21ED29C", VA = "0x21ED29C")]
	private void OnBtnGuestLogin()
	{
	}

	[Token(Token = "0x601082A")]
	[Address(RVA = "0x21ED434", Offset = "0x21ED434", VA = "0x21ED434")]
	private void ProcessGuestRestore()
	{
	}

	[Token(Token = "0x601082B")]
	[Address(RVA = "0x21ED920", Offset = "0x21ED920", VA = "0x21ED920")]
	private void OnMigrateGuestResult(SDKLogin.SAFGuestResult safResult)
	{
	}

	[Token(Token = "0x601082C")]
	[Address(RVA = "0x21EE2B8", Offset = "0x21EE2B8", VA = "0x21EE2B8")]
	private void OnGuestRestorePrompted()
	{
	}

	[Token(Token = "0x601082D")]
	[Address(RVA = "0x21EDF00", Offset = "0x21EDF00", VA = "0x21EDF00")]
	private void GuestRestoreTryAgain()
	{
	}

	[Token(Token = "0x601082E")]
	[Address(RVA = "0x21ED7C8", Offset = "0x21ED7C8", VA = "0x21ED7C8")]
	private void GuestLogin()
	{
	}

	[Token(Token = "0x601082F")]
	[Address(RVA = "0x21EE588", Offset = "0x21EE588", VA = "0x21EE588")]
	private void OnBtnLoginVKClick()
	{
	}

	[Token(Token = "0x6010830")]
	[Address(RVA = "0x21EE5EC", Offset = "0x21EE5EC", VA = "0x21EE5EC")]
	private void OnBtnFacebookClick()
	{
	}

	[Token(Token = "0x6010831")]
	[Address(RVA = "0x21EE650", Offset = "0x21EE650", VA = "0x21EE650")]
	private void OnBtnTwitterClick()
	{
	}

	[Token(Token = "0x6010832")]
	[Address(RVA = "0x21EE6B4", Offset = "0x21EE6B4", VA = "0x21EE6B4")]
	private void OnBtnAppleClick()
	{
	}

	[Token(Token = "0x6010833")]
	[Address(RVA = "0x21EE718", Offset = "0x21EE718", VA = "0x21EE718")]
	private void OnBtnHuaweiClick()
	{
	}

	[Token(Token = "0x6010834")]
	[Address(RVA = "0x21EE7F4", Offset = "0x21EE7F4", VA = "0x21EE7F4")]
	private void OnBtnGarenaClick()
	{
	}

	[Token(Token = "0x6010835")]
	[Address(RVA = "0x21EE858", Offset = "0x21EE858", VA = "0x21EE858")]
	private void OnBtnVKClick()
	{
	}

	[Token(Token = "0x6010836")]
	[Address(RVA = "0x21EE8BC", Offset = "0x21EE8BC", VA = "0x21EE8BC")]
	private void OnBtnGoogleClick()
	{
	}

	[Token(Token = "0x6010837")]
	[Address(RVA = "0x21EE920", Offset = "0x21EE920", VA = "0x21EE920")]
	private void OnMoreChannelClick()
	{
	}

	[Token(Token = "0x6010838")]
	[Address(RVA = "0x21EF198", Offset = "0x21EF198", VA = "0x21EF198")]
	private void GotoLobby()
	{
	}

	[Token(Token = "0x6010839")]
	[Address(RVA = "0x21EF378", Offset = "0x21EF378", VA = "0x21EF378", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601083A")]
	[Address(RVA = "0x21F03FC", Offset = "0x21F03FC", VA = "0x21F03FC", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601083B")]
	[Address(RVA = "0x21E9D28", Offset = "0x21E9D28", VA = "0x21E9D28")]
	private void SelectDefaultServer()
	{
	}

	[Token(Token = "0x601083C")]
	[Address(RVA = "0x21F0490", Offset = "0x21F0490", VA = "0x21F0490")]
	private void OnBtnStartGameClick()
	{
	}

	[Token(Token = "0x601083D")]
	[Address(RVA = "0x21F0860", Offset = "0x21F0860", VA = "0x21F0860")]
	private void ProcessStartGame()
	{
	}

	[Token(Token = "0x601083E")]
	[Address(RVA = "0x21F0268", Offset = "0x21F0268", VA = "0x21F0268")]
	private void OnLogoutBtnClick()
	{
	}

	[Token(Token = "0x601083F")]
	[Address(RVA = "0x21F0AA8", Offset = "0x21F0AA8", VA = "0x21F0AA8")]
	private void OnConfirmChangeServer(object[] data)
	{
	}

	[Token(Token = "0x6010840")]
	[Address(RVA = "0x21F0D18", Offset = "0x21F0D18", VA = "0x21F0D18")]
	private void UpdateLoginButtons()
	{
	}

	[Token(Token = "0x6010841")]
	[Address(RVA = "0x21F1504", Offset = "0x21F1504", VA = "0x21F1504")]
	private bool CheckToggleEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x6010842")]
	[Address(RVA = "0x21EB7D4", Offset = "0x21EB7D4", VA = "0x21EB7D4")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6010843")]
	[Address(RVA = "0x21F1658", Offset = "0x21F1658", VA = "0x21F1658")]
	private void RefreshCachedPlayerInfo()
	{
	}

	[Token(Token = "0x6010844")]
	[Address(RVA = "0x21F1A68", Offset = "0x21F1A68", VA = "0x21F1A68")]
	private void RefreshLoginRegion()
	{
	}

	[Token(Token = "0x6010845")]
	[Address(RVA = "0x21EB6E0", Offset = "0x21EB6E0", VA = "0x21EB6E0")]
	private void RefreshServerInfo(object[] data)
	{
	}

	[Token(Token = "0x6010846")]
	[Address(RVA = "0x21EE468", Offset = "0x21EE468", VA = "0x21EE468")]
	private IEnumerator SetButtonCoolDown(UIButton btn, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x6010847")]
	[Address(RVA = "0x21EC4D0", Offset = "0x21EC4D0", VA = "0x21EC4D0")]
	private bool CheckIfPolicyPopupNeeded(Action callback1, Action<PlatformType> callback2, PlatformType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6010848")]
	[Address(RVA = "0x21F2578", Offset = "0x21F2578", VA = "0x21F2578")]
	private void OnEventCloseLogin(object[] data)
	{
	}

	[Token(Token = "0x6010849")]
	[Address(RVA = "0x21F25E4", Offset = "0x21F25E4", VA = "0x21F25E4")]
	private void OnEventBGSwithc(object[] data)
	{
	}

	[Token(Token = "0x601084A")]
	[Address(RVA = "0x21F2710", Offset = "0x21F2710", VA = "0x21F2710")]
	private void OnDownloadCenterClick()
	{
	}

	[Token(Token = "0x601084B")]
	[Address(RVA = "0x21EA9D0", Offset = "0x21EA9D0", VA = "0x21EA9D0")]
	private void ShowMaintenanceMessage(string content)
	{
	}

	[Token(Token = "0x601084C")]
	[Address(RVA = "0x21F2848", Offset = "0x21F2848", VA = "0x21F2848")]
	private void OnDebugClick()
	{
	}

	[Token(Token = "0x601084D")]
	[Address(RVA = "0x21EAE04", Offset = "0x21EAE04", VA = "0x21EAE04")]
	private void InitBG()
	{
	}

	[Token(Token = "0x601084E")]
	[Address(RVA = "0x21F2D2C", Offset = "0x21F2D2C", VA = "0x21F2D2C")]
	public void ShowSpineBG(ResourceID spineBGResID)
	{
	}

	[Token(Token = "0x601084F")]
	[Address(RVA = "0x21F32DC", Offset = "0x21F32DC", VA = "0x21F32DC")]
	private void OnVNLinkClick()
	{
	}

	[Token(Token = "0x6010850")]
	[Address(RVA = "0x21F2018", Offset = "0x21F2018", VA = "0x21F2018")]
	private void RefreshVNLink()
	{
	}

	[Token(Token = "0x6010851")]
	[Address(RVA = "0x21F2958", Offset = "0x21F2958", VA = "0x21F2958")]
	private void ShowMovieBG()
	{
	}

	[Token(Token = "0x6010852")]
	[Address(RVA = "0x21EB928", Offset = "0x21EB928", VA = "0x21EB928")]
	public void TestInvalideClientVersion()
	{
	}

	[Token(Token = "0x6010853")]
	[Address(RVA = "0x21F3548", Offset = "0x21F3548", VA = "0x21F3548")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6010854")]
	[Address(RVA = "0x21F35E4", Offset = "0x21F35E4", VA = "0x21F35E4")]
	private void _003CGuestRestoreTryAgain_003Em__1()
	{
	}

	[Token(Token = "0x6010855")]
	[Address(RVA = "0x21F374C", Offset = "0x21F374C", VA = "0x21F374C")]
	private static void _003COnDataChanged_003Em__2(SDKLogin.SAFGuestResult safResult)
	{
	}

	[Token(Token = "0x6010856")]
	[Address(RVA = "0x21F3950", Offset = "0x21F3950", VA = "0x21F3950")]
	private static void _003CProcessStartGame_003Em__3()
	{
	}

	[Token(Token = "0x6010857")]
	[Address(RVA = "0x21F3A24", Offset = "0x21F3A24", VA = "0x21F3A24")]
	private static void _003CTestInvalideClientVersion_003Em__4()
	{
	}

	[Token(Token = "0x6010858")]
	[Address(RVA = "0x21F3AD0", Offset = "0x21F3AD0", VA = "0x21F3AD0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010859")]
	[Address(RVA = "0x21F3AD8", Offset = "0x21F3AD8", VA = "0x21F3AD8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
