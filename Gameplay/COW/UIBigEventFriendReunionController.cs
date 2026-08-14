using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E88")]
public class UIBigEventFriendReunionController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C005")]
	[FieldOffset(Offset = "0x48")]
	private UIBigEventFriendReunionView m_View;

	[Token(Token = "0x400C006")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C007")]
	[FieldOffset(Offset = "0x50")]
	private List<UIBaseController> m_FriendReunionControllers;

	[Token(Token = "0x400C008")]
	[FieldOffset(Offset = "0x54")]
	private ActivityGroupDesc m_GroupDesc;

	[Token(Token = "0x400C009")]
	[FieldOffset(Offset = "0x58")]
	private int m_ADWidth;

	[Token(Token = "0x60092EF")]
	[Address(RVA = "0x14175A0", Offset = "0x14175A0", VA = "0x14175A0")]
	public UIBigEventFriendReunionController()
	{
	}

	[Token(Token = "0x60092F0")]
	[Address(RVA = "0x141762C", Offset = "0x141762C", VA = "0x141762C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60092F1")]
	[Address(RVA = "0x14176D4", Offset = "0x14176D4", VA = "0x14176D4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60092F2")]
	[Address(RVA = "0x1418DB0", Offset = "0x1418DB0", VA = "0x1418DB0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60092F3")]
	[Address(RVA = "0x1418EC0", Offset = "0x1418EC0", VA = "0x1418EC0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60092F4")]
	[Address(RVA = "0x141796C", Offset = "0x141796C", VA = "0x141796C")]
	private void CreateEventDescList()
	{
	}

	[Token(Token = "0x60092F5")]
	[Address(RVA = "0x1418F24", Offset = "0x1418F24", VA = "0x1418F24")]
	private void UpdateIntroData(ActivityGroupDesc data)
	{
	}

	[Token(Token = "0x60092F6")]
	[Address(RVA = "0x1419F14", Offset = "0x1419F14", VA = "0x1419F14")]
	private void UpdateActivityInfo()
	{
	}

	[Token(Token = "0x60092F7")]
	[Address(RVA = "0x141A2B0", Offset = "0x141A2B0", VA = "0x141A2B0")]
	public void SetAD(string url)
	{
	}

	[Token(Token = "0x60092F8")]
	[Address(RVA = "0x141A450", Offset = "0x141A450", VA = "0x141A450")]
	private void OnDownloadFinish()
	{
	}

	[Token(Token = "0x60092F9")]
	[Address(RVA = "0x141A648", Offset = "0x141A648", VA = "0x141A648", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60092FA")]
	[Address(RVA = "0x141A708", Offset = "0x141A708", VA = "0x141A708", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60092FB")]
	[Address(RVA = "0x141A79C", Offset = "0x141A79C", VA = "0x141A79C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60092FC")]
	[Address(RVA = "0x141A7A4", Offset = "0x141A7A4", VA = "0x141A7A4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x60092FD")]
	[Address(RVA = "0x141A7AC", Offset = "0x141A7AC", VA = "0x141A7AC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
