using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200237E")]
internal class UIMaxSettingController : UISettingContentBase
{
	[Token(Token = "0x200237F")]
	private enum MaxSettingKey
	{
		[Token(Token = "0x400DCED")]
		LoginVideo,
		[Token(Token = "0x400DCEE")]
		LobbyStyle,
		[Token(Token = "0x400DCEF")]
		AudioStyle,
		[Token(Token = "0x400DCF0")]
		AnimationStyle,
		[Token(Token = "0x400DCF1")]
		HDTexture,
		[Token(Token = "0x400DCF2")]
		VehicleVFX,
		[Token(Token = "0x400DCF3")]
		WeaponEffect,
		[Token(Token = "0x400DCF4")]
		ShowMyLobby,
		[Token(Token = "0x400DCF5")]
		ShowCaptainLobby
	}

	[Token(Token = "0x2002380")]
	private sealed class _003COnSetLobbyShow_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DCF6")]
		[FieldOffset(Offset = "0x8")]
		internal int lobbyType;

		[Token(Token = "0x400DCF7")]
		[FieldOffset(Offset = "0xC")]
		internal UIMaxSettingController _0024this;

		[Token(Token = "0x600C6D0")]
		[Address(RVA = "0x269749C", Offset = "0x269749C", VA = "0x269749C")]
		public _003COnSetLobbyShow_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C6D1")]
		[Address(RVA = "0x269862C", Offset = "0x269862C", VA = "0x269862C")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600C6D2")]
		[Address(RVA = "0x26986B4", Offset = "0x26986B4", VA = "0x26986B4")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400DCE8")]
	[FieldOffset(Offset = "0x2C")]
	private UIMAXSettingView m_View;

	[Token(Token = "0x400DCE9")]
	[FieldOffset(Offset = "0x30")]
	private MaxSettingInfo m_SettingInfo;

	[Token(Token = "0x400DCEA")]
	[FieldOffset(Offset = "0x34")]
	private UICommonSettingContentController m_Ctrl;

	[Token(Token = "0x400DCEB")]
	[FieldOffset(Offset = "0x38")]
	private CommonSettingContentData m_Data;

	[Token(Token = "0x600C69A")]
	[Address(RVA = "0x2692F38", Offset = "0x2692F38", VA = "0x2692F38")]
	public UIMaxSettingController()
	{
	}

	[Token(Token = "0x600C69B")]
	[Address(RVA = "0x2692FB4", Offset = "0x2692FB4", VA = "0x2692FB4", Slot = "33")]
	public override void RefreshContent(object[] param)
	{
	}

	[Token(Token = "0x600C69C")]
	[Address(RVA = "0x26931C0", Offset = "0x26931C0", VA = "0x26931C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C69D")]
	[Address(RVA = "0x2693268", Offset = "0x2693268", VA = "0x2693268", Slot = "32")]
	protected override void InitSettingInfo()
	{
	}

	[Token(Token = "0x600C69E")]
	[Address(RVA = "0x2693498", Offset = "0x2693498", VA = "0x2693498", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C69F")]
	[Address(RVA = "0x2695870", Offset = "0x2695870", VA = "0x2695870")]
	private void Start()
	{
	}

	[Token(Token = "0x600C6A0")]
	[Address(RVA = "0x2693A0C", Offset = "0x2693A0C", VA = "0x2693A0C")]
	private CommonSettingItemDataToggleBtns CreateLoginVideoData()
	{
		return null;
	}

	[Token(Token = "0x600C6A1")]
	[Address(RVA = "0x2693D24", Offset = "0x2693D24", VA = "0x2693D24")]
	private CommonSettingItemDataToggleBtns CreateCanShowLobbyData()
	{
		return null;
	}

	[Token(Token = "0x600C6A2")]
	[Address(RVA = "0x2694028", Offset = "0x2694028", VA = "0x2694028")]
	private CommonSettingItemDataToggleBtns CreateAudioEngineData()
	{
		return null;
	}

	[Token(Token = "0x600C6A3")]
	[Address(RVA = "0x2694A98", Offset = "0x2694A98", VA = "0x2694A98")]
	private CommonSettingItemDataToggleBtns CreateHDAnimationData()
	{
		return null;
	}

	[Token(Token = "0x600C6A4")]
	[Address(RVA = "0x2694D60", Offset = "0x2694D60", VA = "0x2694D60")]
	private CommonSettingItemDataToggleBtns CreateWeaponEffectData()
	{
		return null;
	}

	[Token(Token = "0x600C6A5")]
	[Address(RVA = "0x2695038", Offset = "0x2695038", VA = "0x2695038")]
	private CommonSettingItemDataToggleBtns CreateHDTextureData()
	{
		return null;
	}

	[Token(Token = "0x600C6A6")]
	[Address(RVA = "0x2695310", Offset = "0x2695310", VA = "0x2695310")]
	private CommonSettingItemDataToggleBtns CreateHDVehicleVFXData()
	{
		return null;
	}

	[Token(Token = "0x600C6A7")]
	[Address(RVA = "0x26942F0", Offset = "0x26942F0", VA = "0x26942F0")]
	private CommonSettingItemDataToggleBtns CreateHDShowMyLobby()
	{
		return null;
	}

	[Token(Token = "0x600C6A8")]
	[Address(RVA = "0x26946C4", Offset = "0x26946C4", VA = "0x26946C4")]
	private CommonSettingItemDataToggleBtns CreateHDShowCaptainLobby()
	{
		return null;
	}

	[Token(Token = "0x600C6A9")]
	[Address(RVA = "0x2695A60", Offset = "0x2695A60", VA = "0x2695A60")]
	private int GetLoginVideoSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6AA")]
	[Address(RVA = "0x2695900", Offset = "0x2695900", VA = "0x2695900")]
	private int GetTipsState(string key)
	{
		return default(int);
	}

	[Token(Token = "0x600C6AB")]
	[Address(RVA = "0x2695B2C", Offset = "0x2695B2C", VA = "0x2695B2C")]
	private int GetCanShowLobbyBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6AC")]
	[Address(RVA = "0x2695C04", Offset = "0x2695C04", VA = "0x2695C04")]
	private int GetAudioEngineSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6AD")]
	[Address(RVA = "0x2695CDC", Offset = "0x2695CDC", VA = "0x2695CDC")]
	private int GetHDAnimationSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6AE")]
	[Address(RVA = "0x2695DA8", Offset = "0x2695DA8", VA = "0x2695DA8")]
	private int GetWeaponEffectSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6AF")]
	[Address(RVA = "0x2695E78", Offset = "0x2695E78", VA = "0x2695E78")]
	private int GetHDTextureSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6B0")]
	[Address(RVA = "0x2695F48", Offset = "0x2695F48", VA = "0x2695F48")]
	private int GetHDVehicleVFXSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6B1")]
	[Address(RVA = "0x2696018", Offset = "0x2696018", VA = "0x2696018")]
	private int GetHDShowMyLobbyBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6B2")]
	[Address(RVA = "0x26960E8", Offset = "0x26960E8", VA = "0x26960E8")]
	private int GetHDShowCaptainLobbyBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6B3")]
	[Address(RVA = "0x2693084", Offset = "0x2693084", VA = "0x2693084")]
	private void RefreshBtnsState(object[] param)
	{
	}

	[Token(Token = "0x600C6B4")]
	[Address(RVA = "0x2695654", Offset = "0x2695654", VA = "0x2695654")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x600C6B5")]
	[Address(RVA = "0x26961B8", Offset = "0x26961B8", VA = "0x26961B8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C6B6")]
	[Address(RVA = "0x2696920", Offset = "0x2696920", VA = "0x2696920")]
	private void OnShowStandLobbyClicked()
	{
	}

	[Token(Token = "0x600C6B7")]
	[Address(RVA = "0x2696DF0", Offset = "0x2696DF0", VA = "0x2696DF0")]
	private void OnHideLobbyClicked()
	{
	}

	[Token(Token = "0x600C6B8")]
	[Address(RVA = "0x2696E58", Offset = "0x2696E58", VA = "0x2696E58")]
	private void OnChooseUnityAudioEngine()
	{
	}

	[Token(Token = "0x600C6B9")]
	[Address(RVA = "0x2697084", Offset = "0x2697084", VA = "0x2697084")]
	private void OnChooseWwiseAudioEngine()
	{
	}

	[Token(Token = "0x600C6BA")]
	[Address(RVA = "0x26972B0", Offset = "0x26972B0", VA = "0x26972B0")]
	private void OnCloseHDAnimation()
	{
	}

	[Token(Token = "0x600C6BB")]
	[Address(RVA = "0x269737C", Offset = "0x269737C", VA = "0x269737C")]
	private void OnOpenHDAnimation()
	{
	}

	[Token(Token = "0x600C6BC")]
	[Address(RVA = "0x2696988", Offset = "0x2696988", VA = "0x2696988")]
	private void OnSetLobbyShow(bool flag, int lobbyType)
	{
	}

	[Token(Token = "0x600C6BD")]
	[Address(RVA = "0x26974A4", Offset = "0x26974A4", VA = "0x26974A4")]
	private void OnLoginVideoOn()
	{
	}

	[Token(Token = "0x600C6BE")]
	[Address(RVA = "0x2697570", Offset = "0x2697570", VA = "0x2697570")]
	private void OnLoginVideoOff()
	{
	}

	[Token(Token = "0x600C6BF")]
	[Address(RVA = "0x269763C", Offset = "0x269763C", VA = "0x269763C")]
	private void OnOpenHDWeaponEffect()
	{
	}

	[Token(Token = "0x600C6C0")]
	[Address(RVA = "0x2697708", Offset = "0x2697708", VA = "0x2697708")]
	private void OnCloseHDWeaponEffect()
	{
	}

	[Token(Token = "0x600C6C1")]
	[Address(RVA = "0x26977D4", Offset = "0x26977D4", VA = "0x26977D4")]
	private void OnVFXSettingTipClick()
	{
	}

	[Token(Token = "0x600C6C2")]
	[Address(RVA = "0x2697A30", Offset = "0x2697A30", VA = "0x2697A30")]
	private void OnOpenHDTexture()
	{
	}

	[Token(Token = "0x600C6C3")]
	[Address(RVA = "0x2697AFC", Offset = "0x2697AFC", VA = "0x2697AFC")]
	private void OnCloseHDTexture()
	{
	}

	[Token(Token = "0x600C6C4")]
	[Address(RVA = "0x2697BC8", Offset = "0x2697BC8", VA = "0x2697BC8")]
	private void OnOpenHDVehicleVFX()
	{
	}

	[Token(Token = "0x600C6C5")]
	[Address(RVA = "0x2697C94", Offset = "0x2697C94", VA = "0x2697C94")]
	private void OnCloseHDVehicleVFX()
	{
	}

	[Token(Token = "0x600C6C6")]
	[Address(RVA = "0x2697D60", Offset = "0x2697D60", VA = "0x2697D60")]
	private void OnOpenShowMyLobby()
	{
	}

	[Token(Token = "0x600C6C7")]
	[Address(RVA = "0x269805C", Offset = "0x269805C", VA = "0x269805C")]
	private void OnCloseShowMyLobby()
	{
	}

	[Token(Token = "0x600C6C8")]
	[Address(RVA = "0x26981B4", Offset = "0x26981B4", VA = "0x26981B4")]
	private void OnOpenShowCaptainLobby()
	{
	}

	[Token(Token = "0x600C6C9")]
	[Address(RVA = "0x269830C", Offset = "0x269830C", VA = "0x269830C")]
	private void OnCloseShowCaptainLobby()
	{
	}

	[Token(Token = "0x600C6CA")]
	[Address(RVA = "0x2698464", Offset = "0x2698464", VA = "0x2698464")]
	private void RefreshTipsState(object[] data)
	{
	}

	[Token(Token = "0x600C6CB")]
	[Address(RVA = "0x2697EB8", Offset = "0x2697EB8", VA = "0x2697EB8")]
	private void RefreshTagTipsState(string key, bool refreshAll = true)
	{
	}

	[Token(Token = "0x600C6CC")]
	[Address(RVA = "0x269860C", Offset = "0x269860C", VA = "0x269860C")]
	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}

	[Token(Token = "0x600C6CD")]
	[Address(RVA = "0x2698614", Offset = "0x2698614", VA = "0x2698614")]
	public void _003C_003EiFixBaseProxy_InitSettingInfo()
	{
	}

	[Token(Token = "0x600C6CE")]
	[Address(RVA = "0x269861C", Offset = "0x269861C", VA = "0x269861C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C6CF")]
	[Address(RVA = "0x2698624", Offset = "0x2698624", VA = "0x2698624")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
