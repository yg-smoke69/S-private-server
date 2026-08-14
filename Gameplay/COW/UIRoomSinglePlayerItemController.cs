using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002B02")]
public class UIRoomSinglePlayerItemController : UIEasyListItemController
{
	[Token(Token = "0x40107FD")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomSinglePlayerItemView m_View;

	[Token(Token = "0x40107FE")]
	[FieldOffset(Offset = "0x3C")]
	private RoomGroupInfo m_info;

	[Token(Token = "0x40107FF")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x4010800")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x6011A91")]
	[Address(RVA = "0x2BEB7DC", Offset = "0x2BEB7DC", VA = "0x2BEB7DC")]
	public UIRoomSinglePlayerItemController()
	{
	}

	[Token(Token = "0x6011A92")]
	[Address(RVA = "0x2BEB868", Offset = "0x2BEB868", VA = "0x2BEB868")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A93")]
	[Address(RVA = "0x2BEB90C", Offset = "0x2BEB90C", VA = "0x2BEB90C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A94")]
	[Address(RVA = "0x2BEBB64", Offset = "0x2BEBB64", VA = "0x2BEBB64")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011A95")]
	[Address(RVA = "0x2BEBCE0", Offset = "0x2BEBCE0", VA = "0x2BEBCE0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011A96")]
	[Address(RVA = "0x2BEBE14", Offset = "0x2BEBE14", VA = "0x2BEBE14", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011A97")]
	[Address(RVA = "0x2BEC288", Offset = "0x2BEC288", VA = "0x2BEC288")]
	private void OnSelectedChanged(object[] data)
	{
	}

	[Token(Token = "0x6011A98")]
	[Address(RVA = "0x2BEC3F8", Offset = "0x2BEC3F8", VA = "0x2BEC3F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011A99")]
	[Address(RVA = "0x2BEC400", Offset = "0x2BEC400", VA = "0x2BEC400")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
