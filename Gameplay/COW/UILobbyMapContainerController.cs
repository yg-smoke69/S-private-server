using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200292C")]
public class UILobbyMapContainerController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FD96")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyMapContainerView m_View;

	[Token(Token = "0x400FD97")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x60105BE")]
	[Address(RVA = "0xDBD6F0", Offset = "0xDBD6F0", VA = "0xDBD6F0")]
	public UILobbyMapContainerController()
	{
	}

	[Token(Token = "0x60105BF")]
	[Address(RVA = "0xDBD774", Offset = "0xDBD774", VA = "0xDBD774")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60105C0")]
	[Address(RVA = "0xDBD81C", Offset = "0xDBD81C", VA = "0xDBD81C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60105C1")]
	[Address(RVA = "0xDBDB40", Offset = "0xDBDB40", VA = "0xDBDB40", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60105C2")]
	[Address(RVA = "0xDBDD04", Offset = "0xDBDD04", VA = "0xDBDD04")]
	private void OnServerConfirmed(object[] data)
	{
	}

	[Token(Token = "0x60105C3")]
	[Address(RVA = "0xDBDE04", Offset = "0xDBDE04", VA = "0xDBDE04")]
	public void SetUIData()
	{
	}

	[Token(Token = "0x60105C4")]
	[Address(RVA = "0xDBED88", Offset = "0xDBED88", VA = "0xDBED88")]
	private void OnCustomRoomClick()
	{
	}

	[Token(Token = "0x60105C5")]
	[Address(RVA = "0xDBF2D8", Offset = "0xDBF2D8", VA = "0xDBF2D8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60105C6")]
	[Address(RVA = "0xDBF33C", Offset = "0xDBF33C", VA = "0xDBF33C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60105C7")]
	[Address(RVA = "0xDBF408", Offset = "0xDBF408", VA = "0xDBF408")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60105C8")]
	[Address(RVA = "0xDBF410", Offset = "0xDBF410", VA = "0xDBF410")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
