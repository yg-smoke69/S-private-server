using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029C3")]
public class UIMemberShipReissueSecondConfirmWndController : UIPopupWindowController
{
	[Token(Token = "0x40100F4")]
	[FieldOffset(Offset = "0x48")]
	private UIMemberShipReissueSecondConfirmWndView m_View;

	[Token(Token = "0x40100F5")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMemberShip m_Model;

	[Token(Token = "0x40100F6")]
	[FieldOffset(Offset = "0x50")]
	private ClientReissueItemData m_Data;

	[Token(Token = "0x6010CB3")]
	[Address(RVA = "0x12FF4CC", Offset = "0x12FF4CC", VA = "0x12FF4CC")]
	public UIMemberShipReissueSecondConfirmWndController()
	{
	}

	[Token(Token = "0x6010CB4")]
	[Address(RVA = "0x12FF4D4", Offset = "0x12FF4D4", VA = "0x12FF4D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010CB5")]
	[Address(RVA = "0x12FF578", Offset = "0x12FF578", VA = "0x12FF578", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010CB6")]
	[Address(RVA = "0x12FDF28", Offset = "0x12FDF28", VA = "0x12FDF28")]
	public void SetData(ClientReissueItemData data)
	{
	}

	[Token(Token = "0x6010CB7")]
	[Address(RVA = "0x12FF7B8", Offset = "0x12FF7B8", VA = "0x12FF7B8")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x6010CB8")]
	[Address(RVA = "0x12FF844", Offset = "0x12FF844", VA = "0x12FF844")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
