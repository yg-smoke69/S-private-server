using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B1D")]
public class UISettingController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010878")]
	[FieldOffset(Offset = "0x48")]
	private UISettingView m_View;

	[Token(Token = "0x4010879")]
	[FieldOffset(Offset = "0x4C")]
	private List<UISettingTabButton> m_TabButtons;

	[Token(Token = "0x401087A")]
	[FieldOffset(Offset = "0x50")]
	private bool isInGame;

	[Token(Token = "0x401087B")]
	[FieldOffset(Offset = "0x58")]
	public ulong m_StartShowTime;

	[Token(Token = "0x401087C")]
	[FieldOffset(Offset = "0x60")]
	private UIModelLogin m_LoginModel;

	[Token(Token = "0x401087D")]
	[FieldOffset(Offset = "0x64")]
	private UIDebugInfoController m_debuginfoController;

	[Token(Token = "0x401087E")]
	[FieldOffset(Offset = "0x68")]
	private UISettingContentBase m_AutoPickUpController;

	[Token(Token = "0x401087F")]
	[FieldOffset(Offset = "0x6C")]
	private UIBasicSettingController m_BasicSettingController;

	[Token(Token = "0x4010880")]
	[FieldOffset(Offset = "0x70")]
	private UISoundSettingController m_SoundSettingController;

	[Token(Token = "0x4010881")]
	[FieldOffset(Offset = "0x74")]
	private UIVibrateSettingController m_VibrateSettingController;

	[Token(Token = "0x4010882")]
	[FieldOffset(Offset = "0x78")]
	private UISensiSettingController m_SensiSettingController;

	[Token(Token = "0x4010883")]
	[FieldOffset(Offset = "0x7C")]
	private UIOperationSettingController m_OperationSettingController;

	[Token(Token = "0x4010884")]
	[FieldOffset(Offset = "0x80")]
	private UINotificationSettingController m_NotificationSettingController;

	[Token(Token = "0x4010885")]
	[FieldOffset(Offset = "0x84")]
	private UIGraphicSettingController m_GraphicSettingController;

	[Token(Token = "0x4010886")]
	[FieldOffset(Offset = "0x88")]
	private UIUGCSettingController m_UGCSettingController;

	[Token(Token = "0x4010887")]
	[FieldOffset(Offset = "0x8C")]
	private SettingPageType m_PreSettingType;

	[Token(Token = "0x4010888")]
	[FieldOffset(Offset = "0x90")]
	private UIMaxSettingController m_MaxSettingController;

	[Token(Token = "0x4010889")]
	private const string MAXSettingRedTips = "MAXSettingRedTips";

	[Token(Token = "0x401088A")]
	[FieldOffset(Offset = "0x94")]
	private UISettingContentBase m_CurrentShowContent;

	[Token(Token = "0x401088B")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6011B8F")]
	[Address(RVA = "0x1A57114", Offset = "0x1A57114", VA = "0x1A57114")]
	public UISettingController()
	{
	}

	[Token(Token = "0x6011B90")]
	[Address(RVA = "0x1A571A0", Offset = "0x1A571A0", VA = "0x1A571A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011B91")]
	[Address(RVA = "0x1A57244", Offset = "0x1A57244", VA = "0x1A57244", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011B92")]
	[Address(RVA = "0x1A58BB8", Offset = "0x1A58BB8", VA = "0x1A58BB8")]
	private void InitNotifications()
	{
	}

	[Token(Token = "0x6011B93")]
	[Address(RVA = "0x1A58ECC", Offset = "0x1A58ECC", VA = "0x1A58ECC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011B94")]
	[Address(RVA = "0x1A59054", Offset = "0x1A59054", VA = "0x1A59054", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6011B95")]
	[Address(RVA = "0x1A590AC", Offset = "0x1A590AC", VA = "0x1A590AC")]
	private void OnCloseClick()
	{
	}

	[Token(Token = "0x6011B96")]
	[Address(RVA = "0x1A591D0", Offset = "0x1A591D0", VA = "0x1A591D0")]
	private void OnQuitButtonClick()
	{
	}

	[Token(Token = "0x6011B97")]
	[Address(RVA = "0x1A592DC", Offset = "0x1A592DC", VA = "0x1A592DC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011B98")]
	[Address(RVA = "0x1A598C4", Offset = "0x1A598C4", VA = "0x1A598C4")]
	private UISettingContentBase GetContent(SettingPageType settingType)
	{
		return null;
	}

	[Token(Token = "0x6011B99")]
	[Address(RVA = "0x1A5A384", Offset = "0x1A5A384", VA = "0x1A5A384")]
	private void OnTopTabClick(SettingPageType settingType)
	{
	}

	[Token(Token = "0x6011B9A")]
	[Address(RVA = "0x1A5A6DC", Offset = "0x1A5A6DC", VA = "0x1A5A6DC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011B9B")]
	[Address(RVA = "0x1A5AC48", Offset = "0x1A5AC48", VA = "0x1A5AC48", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011B9C")]
	[Address(RVA = "0x1A5AD00", Offset = "0x1A5AD00", VA = "0x1A5AD00")]
	public void SetInGameShow(bool isIngame)
	{
	}

	[Token(Token = "0x6011B9D")]
	[Address(RVA = "0x1A58A3C", Offset = "0x1A58A3C", VA = "0x1A58A3C")]
	private int GetMAXRedTipsState()
	{
		return default(int);
	}

	[Token(Token = "0x6011B9E")]
	[Address(RVA = "0x1A5B0DC", Offset = "0x1A5B0DC", VA = "0x1A5B0DC")]
	private void SetMaxRedTipsState(int value)
	{
	}

	[Token(Token = "0x6011B9F")]
	[Address(RVA = "0x1A5B214", Offset = "0x1A5B214", VA = "0x1A5B214")]
	private static bool _003COnUIInit_003Em__0(string x)
	{
		return default(bool);
	}

	[Token(Token = "0x6011BA0")]
	[Address(RVA = "0x1A5B2EC", Offset = "0x1A5B2EC", VA = "0x1A5B2EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011BA1")]
	[Address(RVA = "0x1A5B2F4", Offset = "0x1A5B2F4", VA = "0x1A5B2F4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011BA2")]
	[Address(RVA = "0x1A5B2FC", Offset = "0x1A5B2FC", VA = "0x1A5B2FC")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6011BA3")]
	[Address(RVA = "0x1A5B304", Offset = "0x1A5B304", VA = "0x1A5B304")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
