using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002762")]
public class UIHudGameVoiceController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F327")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGameVoiceView m_View;

	[Token(Token = "0x400F328")]
	[FieldOffset(Offset = "0x2C")]
	private HashSet<IHAAMHPPLMG> m_TeammateIDList;

	[Token(Token = "0x400F329")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, TeammateVoiceView> m_TeammatesVoiceViewMap;

	[Token(Token = "0x600F0A1")]
	[Address(RVA = "0x188E34C", Offset = "0x188E34C", VA = "0x188E34C")]
	public UIHudGameVoiceController()
	{
	}

	[Token(Token = "0x600F0A2")]
	[Address(RVA = "0x188E438", Offset = "0x188E438", VA = "0x188E438")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F0A3")]
	[Address(RVA = "0x188E4DC", Offset = "0x188E4DC", VA = "0x188E4DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F0A4")]
	[Address(RVA = "0x1890628", Offset = "0x1890628", VA = "0x1890628")]
	public void SwitchOnMicroPhone()
	{
	}

	[Token(Token = "0x600F0A5")]
	[Address(RVA = "0x18906B8", Offset = "0x18906B8", VA = "0x18906B8")]
	private void OnTeammateMuteStateChange(object[] data)
	{
	}

	[Token(Token = "0x600F0A6")]
	[Address(RVA = "0x1890C08", Offset = "0x1890C08", VA = "0x1890C08", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F0A7")]
	[Address(RVA = "0x1890F04", Offset = "0x1890F04", VA = "0x1890F04")]
	private void OnVoicePanelMaskClick()
	{
	}

	[Token(Token = "0x600F0A8")]
	[Address(RVA = "0x1890FD4", Offset = "0x1890FD4", VA = "0x1890FD4")]
	private void ShowTurnOnMicTutorial(object[] data)
	{
	}

	[Token(Token = "0x600F0A9")]
	[Address(RVA = "0x1891110", Offset = "0x1891110", VA = "0x1891110")]
	private void OnSpeakerMuteToggleClicked()
	{
	}

	[Token(Token = "0x600F0AA")]
	[Address(RVA = "0x189130C", Offset = "0x189130C", VA = "0x189130C")]
	private void OnSpeakerMuteAllBtnClicked()
	{
	}

	[Token(Token = "0x600F0AB")]
	[Address(RVA = "0x1891904", Offset = "0x1891904", VA = "0x1891904")]
	private void OnMicroPhoneMuteToggleChange()
	{
	}

	[Token(Token = "0x600F0AC")]
	[Address(RVA = "0x1891A40", Offset = "0x1891A40", VA = "0x1891A40")]
	private void OnMicrophoneChanged(object[] data)
	{
	}

	[Token(Token = "0x600F0AD")]
	[Address(RVA = "0x188F580", Offset = "0x188F580", VA = "0x188F580")]
	private void RefreshToggleView()
	{
	}

	[Token(Token = "0x600F0AE")]
	[Address(RVA = "0x18916C0", Offset = "0x18916C0", VA = "0x18916C0")]
	private void RefreshTeammateVoice()
	{
	}

	[Token(Token = "0x600F0AF")]
	[Address(RVA = "0x1891DF8", Offset = "0x1891DF8", VA = "0x1891DF8")]
	private void OnJoinedRoom(object[] data)
	{
	}

	[Token(Token = "0x600F0B0")]
	[Address(RVA = "0x1891EC8", Offset = "0x1891EC8", VA = "0x1891EC8")]
	private void OnLeavedRoom(object[] data)
	{
	}

	[Token(Token = "0x600F0B1")]
	[Address(RVA = "0x188FA58", Offset = "0x188FA58", VA = "0x188FA58")]
	private void RefreshVoiceViewPanel()
	{
	}

	[Token(Token = "0x600F0B2")]
	[Address(RVA = "0x18920DC", Offset = "0x18920DC", VA = "0x18920DC", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F0B3")]
	[Address(RVA = "0x1892434", Offset = "0x1892434", VA = "0x1892434", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F0B4")]
	[Address(RVA = "0x18924C8", Offset = "0x18924C8", VA = "0x18924C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F0B5")]
	[Address(RVA = "0x18924D0", Offset = "0x18924D0", VA = "0x18924D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
