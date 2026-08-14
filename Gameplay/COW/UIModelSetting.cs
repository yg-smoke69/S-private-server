using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using GarenaMSDK;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003252")]
public class UIModelSetting : UIBaseModel
{
	[Token(Token = "0x2003253")]
	public enum SyncStatus
	{
		[Token(Token = "0x4013250")]
		UpCover,
		[Token(Token = "0x4013251")]
		DownCover,
		[Token(Token = "0x4013252")]
		DownloadNotFound
	}

	[Token(Token = "0x4013239")]
	public const int PropID_UploadSettingCover = 1;

	[Token(Token = "0x401323A")]
	public const int PropID_UploadSettingStart = 2;

	[Token(Token = "0x401323B")]
	public const int PropID_UploadSettingFinish = 4;

	[Token(Token = "0x401323C")]
	public const int PropID_DownloadSettingCover = 8;

	[Token(Token = "0x401323D")]
	public const int PropID_DownloadSettingFailure = 16;

	[Token(Token = "0x401323E")]
	public const int PropID_DownloadSettingFinish = 32;

	[Token(Token = "0x401323F")]
	public const int PropID_UploadFailure = 64;

	[Token(Token = "0x4013240")]
	public const int PropID_DownloadFailure = 128;

	[Token(Token = "0x4013241")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, HudConfigItem> m_HudDefaultConfigDic;

	[Token(Token = "0x4013242")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, HudConfigItem> m_HudCustomizeConfigDic;

	[Token(Token = "0x4013243")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, HudConfigItem> m_HudChangedConfigDic;

	[Token(Token = "0x4013244")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, HudConfigItem> m_HudNewDefaultConfigDic;

	[Token(Token = "0x4013245")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<string, HudConfigItem> m_HudNewCustomizeConfigDic;

	[Token(Token = "0x4013246")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, HudConfigItem> m_HudNewChangedConfigDic;

	[Token(Token = "0x4013247")]
	[FieldOffset(Offset = "0x24")]
	private string m_SettingSyncGuide;

	[Token(Token = "0x4013248")]
	[FieldOffset(Offset = "0x28")]
	private byte[] m_SettingDetailSerialized;

	[Token(Token = "0x4013249")]
	[FieldOffset(Offset = "0x2C")]
	private string m_Version;

	[Token(Token = "0x401324A")]
	[FieldOffset(Offset = "0x30")]
	private SettingsTransferStatus m_Flag;

	[Token(Token = "0x401324B")]
	[FieldOffset(Offset = "0x34")]
	private int m_UIRootWidth;

	[Token(Token = "0x401324C")]
	[FieldOffset(Offset = "0x0")]
	private static bool _ShownGuestRestorePopUp;

	[Token(Token = "0x401324D")]
	[FieldOffset(Offset = "0x4")]
	private static SDKLogin.SAFGuestCb _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401324E")]
	[FieldOffset(Offset = "0x8")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17001659")]
	public int UIRootWidth
	{
		[Token(Token = "0x601537B")]
		[Address(RVA = "0x30E55C0", Offset = "0x30E55C0", VA = "0x30E55C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x601537A")]
	[Address(RVA = "0x30E5434", Offset = "0x30E5434", VA = "0x30E5434")]
	public UIModelSetting()
	{
	}

	[Token(Token = "0x601537C")]
	[Address(RVA = "0x30E56F0", Offset = "0x30E56F0", VA = "0x30E56F0", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601537D")]
	[Address(RVA = "0x30E5830", Offset = "0x30E5830", VA = "0x30E5830")]
	private byte[] ZipString(string unCompressedString)
	{
		return null;
	}

	[Token(Token = "0x601537E")]
	[Address(RVA = "0x30E5A10", Offset = "0x30E5A10", VA = "0x30E5A10")]
	private string UnZipString(byte[] bytData)
	{
		return null;
	}

	[Token(Token = "0x601537F")]
	[Address(RVA = "0x30E5C5C", Offset = "0x30E5C5C", VA = "0x30E5C5C")]
	public string GetSettingMD5()
	{
		return null;
	}

	[Token(Token = "0x6015380")]
	[Address(RVA = "0x30E6E58", Offset = "0x30E6E58", VA = "0x30E6E58")]
	public void CheckUploadSetting()
	{
	}

	[Token(Token = "0x6015381")]
	[Address(RVA = "0x30E7E04", Offset = "0x30E7E04", VA = "0x30E7E04")]
	public void UploadSetting()
	{
	}

	[Token(Token = "0x6015382")]
	[Address(RVA = "0x30E7E90", Offset = "0x30E7E90", VA = "0x30E7E90")]
	public void RequestUploadSetting()
	{
	}

	[Token(Token = "0x6015383")]
	[Address(RVA = "0x30E7840", Offset = "0x30E7840", VA = "0x30E7840")]
	public void ExportUploadSetting()
	{
	}

	[Token(Token = "0x6015384")]
	[Address(RVA = "0x30E8148", Offset = "0x30E8148", VA = "0x30E8148")]
	public void CheckDownloadSetting()
	{
	}

	[Token(Token = "0x6015385")]
	[Address(RVA = "0x30E8480", Offset = "0x30E8480", VA = "0x30E8480")]
	public void DownloadSetting()
	{
	}

	[Token(Token = "0x6015386")]
	[Address(RVA = "0x30E86FC", Offset = "0x30E86FC", VA = "0x30E86FC")]
	private void GetDownloadedHudConfig(string pos, Dictionary<string, HudConfigItem> hudChanged)
	{
	}

	[Token(Token = "0x6015387")]
	[Address(RVA = "0x30E8D44", Offset = "0x30E8D44", VA = "0x30E8D44")]
	private void CompareHudConfigForDownload()
	{
	}

	[Token(Token = "0x6015388")]
	[Address(RVA = "0x30E934C", Offset = "0x30E934C", VA = "0x30E934C")]
	private void SetHudConfig()
	{
	}

	[Token(Token = "0x6015389")]
	[Address(RVA = "0x30E94C8", Offset = "0x30E94C8", VA = "0x30E94C8")]
	private void SetOtherConfig(SettingDetail settingDetail)
	{
	}

	[Token(Token = "0x601538A")]
	[Address(RVA = "0x30E7160", Offset = "0x30E7160", VA = "0x30E7160")]
	private void GetDefaultHudConfig()
	{
	}

	[Token(Token = "0x601538B")]
	[Address(RVA = "0x30E7290", Offset = "0x30E7290", VA = "0x30E7290")]
	private void LoadHudConfigFromPlayerPref()
	{
	}

	[Token(Token = "0x601538C")]
	[Address(RVA = "0x30E73C0", Offset = "0x30E73C0", VA = "0x30E73C0")]
	private void CompareHudConfigForUpload()
	{
	}

	[Token(Token = "0x601538D")]
	[Address(RVA = "0x30EA528", Offset = "0x30EA528", VA = "0x30EA528")]
	public void SetSettingGuide()
	{
	}

	[Token(Token = "0x601538E")]
	[Address(RVA = "0x30EA600", Offset = "0x30EA600", VA = "0x30EA600")]
	public int GetSettingGuide()
	{
		return default(int);
	}

	[Token(Token = "0x601538F")]
	[Address(RVA = "0x30EA6D8", Offset = "0x30EA6D8", VA = "0x30EA6D8")]
	public void InitSettingLogAll()
	{
	}

	[Token(Token = "0x6015390")]
	[Address(RVA = "0x30EB628", Offset = "0x30EB628", VA = "0x30EB628")]
	public bool ShowGuestRestoreInSettings()
	{
		return default(bool);
	}

	[Token(Token = "0x6015391")]
	[Address(RVA = "0x30EB770", Offset = "0x30EB770", VA = "0x30EB770")]
	public bool ShowGuestBackupInSettings()
	{
		return default(bool);
	}

	[Token(Token = "0x6015392")]
	[Address(RVA = "0x30EB7C8", Offset = "0x30EB7C8", VA = "0x30EB7C8")]
	public void GuestRestore()
	{
	}

	[Token(Token = "0x6015393")]
	[Address(RVA = "0x30EB9B0", Offset = "0x30EB9B0", VA = "0x30EB9B0")]
	public void GuestBackUp()
	{
	}

	[Token(Token = "0x6015394")]
	[Address(RVA = "0x30EBA04", Offset = "0x30EBA04", VA = "0x30EBA04")]
	public bool ShowGuestRestorePopUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6015395")]
	[Address(RVA = "0x30EBB9C", Offset = "0x30EBB9C", VA = "0x30EBB9C")]
	public void ShowGuestRestorePopUpDone()
	{
	}

	[Token(Token = "0x6015396")]
	[Address(RVA = "0x30EBC78", Offset = "0x30EBC78", VA = "0x30EBC78")]
	public void GetNowSettingLogAll()
	{
	}

	[Token(Token = "0x6015397")]
	[Address(RVA = "0x30ECBC8", Offset = "0x30ECBC8", VA = "0x30ECBC8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015398")]
	[Address(RVA = "0x30ECC20", Offset = "0x30ECC20", VA = "0x30ECC20")]
	public CommonSettingItemDataToggleBtns CreateCommonSettingToggleData(string CommonPrefKey, string leftLabelKey, List<int> valList, List<string> togglesKeyList, int defalutValue = 0, [Optional] Action tipBtnClickCallBack)
	{
		return null;
	}

	[Token(Token = "0x6015399")]
	[Address(RVA = "0x30ECD80", Offset = "0x30ECD80", VA = "0x30ECD80")]
	public void RequestCsSetHideMyLobbyInPrefersReq(bool show)
	{
	}

	[Token(Token = "0x601539B")]
	[Address(RVA = "0x30ED0C8", Offset = "0x30ED0C8", VA = "0x30ED0C8")]
	private void _003CCheckUploadSetting_003Em__0(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x601539C")]
	[Address(RVA = "0x30ED2C0", Offset = "0x30ED2C0", VA = "0x30ED2C0")]
	private void _003CRequestUploadSetting_003Em__1(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x601539D")]
	[Address(RVA = "0x30ED450", Offset = "0x30ED450", VA = "0x30ED450")]
	private void _003CCheckDownloadSetting_003Em__2(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x601539E")]
	[Address(RVA = "0x30ED648", Offset = "0x30ED648", VA = "0x30ED648")]
	private void _003CDownloadSetting_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601539F")]
	[Address(RVA = "0x30EDC6C", Offset = "0x30EDC6C", VA = "0x30EDC6C")]
	private static void _003CGuestRestore_003Em__4(SDKLogin.SAFGuestResult safResult)
	{
	}

	[Token(Token = "0x60153A0")]
	[Address(RVA = "0x30EE310", Offset = "0x30EE310", VA = "0x30EE310")]
	private static void _003CRequestCsSetHideMyLobbyInPrefersReq_003Em__5(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60153A1")]
	[Address(RVA = "0x30EE314", Offset = "0x30EE314", VA = "0x30EE314")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}
}
