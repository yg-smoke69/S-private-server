using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002ABD")]
public class UIRegisterController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002ABE")]
	public enum RegisterState
	{
		[Token(Token = "0x40106BB")]
		None,
		[Token(Token = "0x40106BC")]
		NewbieVerteranCheck,
		[Token(Token = "0x40106BD")]
		Name,
		[Token(Token = "0x40106BE")]
		Finish
	}

	[Token(Token = "0x40106B0")]
	[FieldOffset(Offset = "0x28")]
	private UIRegisterView m_View;

	[Token(Token = "0x40106B1")]
	[FieldOffset(Offset = "0x2C")]
	private RegisterState m_RegisterState;

	[Token(Token = "0x40106B2")]
	[FieldOffset(Offset = "0x30")]
	private string m_RegisterName;

	[Token(Token = "0x40106B3")]
	[FieldOffset(Offset = "0x34")]
	private uint m_RegisterAvatarID;

	[Token(Token = "0x40106B4")]
	[FieldOffset(Offset = "0x38")]
	private UICreateCharacterController m_CtrlCreateName;

	[Token(Token = "0x40106B5")]
	[FieldOffset(Offset = "0x3C")]
	private UICheckIsNewbieOrVeteranController m_CtrlCheckIsNewbieOrVerteran;

	[Token(Token = "0x40106B6")]
	private const float m_ExitAnimDuration = 0.5f;

	[Token(Token = "0x40106B7")]
	[FieldOffset(Offset = "0x40")]
	private uint m_DelayCallExitAnimFinish;

	[Token(Token = "0x40106B8")]
	[FieldOffset(Offset = "0x44")]
	private uint m_DelayCallShowBtnClose;

	[Token(Token = "0x40106B9")]
	[FieldOffset(Offset = "0x48")]
	private float m_OpenCreateNameTime;

	[Token(Token = "0x6011811")]
	[Address(RVA = "0x1E42E50", Offset = "0x1E42E50", VA = "0x1E42E50")]
	public UIRegisterController()
	{
	}

	[Token(Token = "0x6011812")]
	[Address(RVA = "0x1E42ED4", Offset = "0x1E42ED4", VA = "0x1E42ED4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011813")]
	[Address(RVA = "0x1E42F78", Offset = "0x1E42F78", VA = "0x1E42F78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011814")]
	[Address(RVA = "0x1E43A5C", Offset = "0x1E43A5C", VA = "0x1E43A5C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011815")]
	[Address(RVA = "0x1E438CC", Offset = "0x1E438CC", VA = "0x1E438CC")]
	private void OnShowedFlow()
	{
	}

	[Token(Token = "0x6011816")]
	[Address(RVA = "0x1E44004", Offset = "0x1E44004", VA = "0x1E44004", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011817")]
	[Address(RVA = "0x1E446E4", Offset = "0x1E446E4", VA = "0x1E446E4", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011818")]
	[Address(RVA = "0x1E43350", Offset = "0x1E43350", VA = "0x1E43350")]
	private void OnSwitchRegisterState(RegisterState nextState)
	{
	}

	[Token(Token = "0x6011819")]
	[Address(RVA = "0x1E44AB0", Offset = "0x1E44AB0", VA = "0x1E44AB0")]
	private void OnRegisterNameConfirm(object[] data)
	{
	}

	[Token(Token = "0x601181A")]
	[Address(RVA = "0x1E43DE8", Offset = "0x1E43DE8", VA = "0x1E43DE8")]
	private void OnRegisterCheckNewbieVeteranConfirm(object[] data)
	{
	}

	[Token(Token = "0x601181B")]
	[Address(RVA = "0x1E44EB8", Offset = "0x1E44EB8", VA = "0x1E44EB8")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x601181C")]
	[Address(RVA = "0x1E44778", Offset = "0x1E44778", VA = "0x1E44778")]
	private void SwitchCaption(string key)
	{
	}

	[Token(Token = "0x601181D")]
	[Address(RVA = "0x1E451E0", Offset = "0x1E451E0", VA = "0x1E451E0")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x601181E")]
	[Address(RVA = "0x1E45244", Offset = "0x1E45244", VA = "0x1E45244")]
	private void _003COnDataChanged_003Em__0()
	{
	}

	[Token(Token = "0x601181F")]
	[Address(RVA = "0x1E45324", Offset = "0x1E45324", VA = "0x1E45324")]
	private void _003COnDataChanged_003Em__1()
	{
	}

	[Token(Token = "0x6011820")]
	[Address(RVA = "0x1E453EC", Offset = "0x1E453EC", VA = "0x1E453EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011821")]
	[Address(RVA = "0x1E453F4", Offset = "0x1E453F4", VA = "0x1E453F4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
