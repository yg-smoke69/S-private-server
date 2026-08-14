using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002AF8")]
public class UIRoomPentaPlayerItemController : UIEasyListItemController
{
	[Token(Token = "0x40107C7")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomPentaPlayerItemView m_View;

	[Token(Token = "0x40107C8")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomPlayerInfo> m_Members;

	[Token(Token = "0x40107C9")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x40107CA")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x6011A33")]
	[Address(RVA = "0x23D93FC", Offset = "0x23D93FC", VA = "0x23D93FC")]
	public UIRoomPentaPlayerItemController()
	{
	}

	[Token(Token = "0x6011A34")]
	[Address(RVA = "0x23D9488", Offset = "0x23D9488", VA = "0x23D9488")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A35")]
	[Address(RVA = "0x23D952C", Offset = "0x23D952C", VA = "0x23D952C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A36")]
	[Address(RVA = "0x23D99E0", Offset = "0x23D99E0", VA = "0x23D99E0")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011A37")]
	[Address(RVA = "0x23D9B5C", Offset = "0x23D9B5C", VA = "0x23D9B5C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011A38")]
	[Address(RVA = "0x23D9F34", Offset = "0x23D9F34", VA = "0x23D9F34")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
