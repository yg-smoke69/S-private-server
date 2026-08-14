using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002182")]
public class UILinkActivityEntryController : UIBaseController, _Attribute
{
	[Token(Token = "0x400D22F")]
	[FieldOffset(Offset = "0x28")]
	private UILinkActivityEntryView m_View;

	[Token(Token = "0x400D230")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelLinkActivity m_Model;

	[Token(Token = "0x400D231")]
	[FieldOffset(Offset = "0x30")]
	private UILinkActivityDetailController m_Window;

	[Token(Token = "0x600B1B7")]
	[Address(RVA = "0x2552A0C", Offset = "0x2552A0C", VA = "0x2552A0C")]
	public UILinkActivityEntryController()
	{
	}

	[Token(Token = "0x600B1B8")]
	[Address(RVA = "0x2552A90", Offset = "0x2552A90", VA = "0x2552A90")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B1B9")]
	[Address(RVA = "0x2552B38", Offset = "0x2552B38", VA = "0x2552B38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B1BA")]
	[Address(RVA = "0x25531E8", Offset = "0x25531E8", VA = "0x25531E8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B1BB")]
	[Address(RVA = "0x2553340", Offset = "0x2553340", VA = "0x2553340", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B1BC")]
	[Address(RVA = "0x25533A4", Offset = "0x25533A4", VA = "0x25533A4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B1BD")]
	[Address(RVA = "0x255302C", Offset = "0x255302C", VA = "0x255302C")]
	private void UpdateBtnState()
	{
	}

	[Token(Token = "0x600B1BE")]
	[Address(RVA = "0x2553434", Offset = "0x2553434", VA = "0x2553434")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600B1BF")]
	[Address(RVA = "0x255399C", Offset = "0x255399C", VA = "0x255399C")]
	private void OnGameModeViewShowHide(object[] data)
	{
	}

	[Token(Token = "0x600B1C0")]
	[Address(RVA = "0x25536B8", Offset = "0x25536B8", VA = "0x25536B8")]
	private void OnClickPVELink()
	{
	}

	[Token(Token = "0x600B1C1")]
	[Address(RVA = "0x2553AF4", Offset = "0x2553AF4", VA = "0x2553AF4")]
	private void OnPVELinkPageSwitch()
	{
	}

	[Token(Token = "0x600B1C2")]
	[Address(RVA = "0x2553BF8", Offset = "0x2553BF8", VA = "0x2553BF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B1C3")]
	[Address(RVA = "0x2553C00", Offset = "0x2553C00", VA = "0x2553C00")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
