using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002AD2")]
public class UIRewardedVideoPopupWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002AD3")]
	private enum UIState
	{
		[Token(Token = "0x4010717")]
		None,
		[Token(Token = "0x4010718")]
		Loading,
		[Token(Token = "0x4010719")]
		Playing
	}

	[Token(Token = "0x4010711")]
	[FieldOffset(Offset = "0x48")]
	private UIRewardedVideoPopupWindowView m_View;

	[Token(Token = "0x4010712")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelRewardedVideo m_RewardedVideoModel;

	[Token(Token = "0x4010713")]
	[FieldOffset(Offset = "0x50")]
	private UIModelActivity m_ActivityModel;

	[Token(Token = "0x4010714")]
	[FieldOffset(Offset = "0x54")]
	private EActivity.Event m_EventOnTrigger;

	[Token(Token = "0x4010715")]
	[FieldOffset(Offset = "0x58")]
	private UIState _State;

	[Token(Token = "0x170012D7")]
	private UIState State
	{
		[Token(Token = "0x60118C6")]
		[Address(RVA = "0x1E59AE0", Offset = "0x1E59AE0", VA = "0x1E59AE0")]
		get
		{
			return default(UIState);
		}
		[Token(Token = "0x60118C7")]
		[Address(RVA = "0x1E59B38", Offset = "0x1E59B38", VA = "0x1E59B38")]
		set
		{
		}
	}

	[Token(Token = "0x60118C4")]
	[Address(RVA = "0x1E59A2C", Offset = "0x1E59A2C", VA = "0x1E59A2C")]
	public UIRewardedVideoPopupWindowController()
	{
	}

	[Token(Token = "0x60118C5")]
	[Address(RVA = "0x1E59A3C", Offset = "0x1E59A3C", VA = "0x1E59A3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60118C8")]
	[Address(RVA = "0x1E59FCC", Offset = "0x1E59FCC", VA = "0x1E59FCC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60118C9")]
	[Address(RVA = "0x1E5A250", Offset = "0x1E5A250", VA = "0x1E5A250")]
	public void SetData(EActivity.Event evt, string desc)
	{
	}

	[Token(Token = "0x60118CA")]
	[Address(RVA = "0x1E5A40C", Offset = "0x1E5A40C", VA = "0x1E5A40C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60118CB")]
	[Address(RVA = "0x1E5A500", Offset = "0x1E5A500", VA = "0x1E5A500", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60118CC")]
	[Address(RVA = "0x1E5A5A0", Offset = "0x1E5A5A0", VA = "0x1E5A5A0")]
	private void OnBtnLoadAndPlayClick()
	{
	}

	[Token(Token = "0x60118CD")]
	[Address(RVA = "0x1E5A610", Offset = "0x1E5A610", VA = "0x1E5A610")]
	private void LoadRewardedVideo()
	{
	}

	[Token(Token = "0x60118CE")]
	[Address(RVA = "0x1E5A6F0", Offset = "0x1E5A6F0", VA = "0x1E5A6F0")]
	private void PlayRewardedVideo()
	{
	}

	[Token(Token = "0x60118CF")]
	[Address(RVA = "0x1E59CAC", Offset = "0x1E59CAC", VA = "0x1E59CAC")]
	private void UpdateUIStatus()
	{
	}

	[Token(Token = "0x60118D0")]
	[Address(RVA = "0x1E5A7CC", Offset = "0x1E5A7CC", VA = "0x1E5A7CC")]
	private void ToggleBtnLoadAndPlay(bool enabled)
	{
	}

	[Token(Token = "0x60118D1")]
	[Address(RVA = "0x1E5A910", Offset = "0x1E5A910", VA = "0x1E5A910", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60118D2")]
	[Address(RVA = "0x1E5A9C8", Offset = "0x1E5A9C8", VA = "0x1E5A9C8", Slot = "42")]
	public override void EnterByReturn()
	{
	}

	[Token(Token = "0x60118D3")]
	[Address(RVA = "0x1E5AACC", Offset = "0x1E5AACC", VA = "0x1E5AACC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60118D4")]
	[Address(RVA = "0x1E5AD28", Offset = "0x1E5AD28", VA = "0x1E5AD28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60118D5")]
	[Address(RVA = "0x1E5AD30", Offset = "0x1E5AD30", VA = "0x1E5AD30")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60118D6")]
	[Address(RVA = "0x1E5AD38", Offset = "0x1E5AD38", VA = "0x1E5AD38")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60118D7")]
	[Address(RVA = "0x1E5AD40", Offset = "0x1E5AD40", VA = "0x1E5AD40")]
	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}
}
