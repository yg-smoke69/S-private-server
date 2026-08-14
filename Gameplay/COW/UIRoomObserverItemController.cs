using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x2002AF5")]
public class UIRoomObserverItemController : UIBaseController
{
	[Token(Token = "0x40107B9")]
	[FieldOffset(Offset = "0x0")]
	private static Color NAME_NORMAL;

	[Token(Token = "0x40107BA")]
	[FieldOffset(Offset = "0x10")]
	private static Color NAME_NORMALSELF;

	[Token(Token = "0x40107BB")]
	[FieldOffset(Offset = "0x20")]
	private static Color NAME_WARNING;

	[Token(Token = "0x40107BC")]
	[FieldOffset(Offset = "0x28")]
	private UIWidget m_ItemWidget;

	[Token(Token = "0x40107BD")]
	[FieldOffset(Offset = "0x2C")]
	private UIRoomObserverItemView m_View;

	[Token(Token = "0x40107BE")]
	[FieldOffset(Offset = "0x30")]
	private RoomPlayerInfo m_info;

	[Token(Token = "0x40107BF")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsEmptySeat;

	[Token(Token = "0x40107C0")]
	[FieldOffset(Offset = "0x38")]
	private UIModelCustomRoom m_Model;

	[Token(Token = "0x6011A1E")]
	[Address(RVA = "0x23D5940", Offset = "0x23D5940", VA = "0x23D5940")]
	public UIRoomObserverItemController()
	{
	}

	[Token(Token = "0x6011A1F")]
	[Address(RVA = "0x23D59C4", Offset = "0x23D59C4", VA = "0x23D59C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A20")]
	[Address(RVA = "0x23D5A68", Offset = "0x23D5A68", VA = "0x23D5A68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A21")]
	[Address(RVA = "0x23D5C3C", Offset = "0x23D5C3C", VA = "0x23D5C3C")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011A22")]
	[Address(RVA = "0x23D5E2C", Offset = "0x23D5E2C", VA = "0x23D5E2C")]
	private void OnItemClick()
	{
	}

	[Token(Token = "0x6011A23")]
	[Address(RVA = "0x23D65E8", Offset = "0x23D65E8", VA = "0x23D65E8")]
	private void OnGotoSeat(object data)
	{
	}

	[Token(Token = "0x6011A24")]
	[Address(RVA = "0x23D675C", Offset = "0x23D675C", VA = "0x23D675C")]
	public void SetUIData(RoomPlayerInfo info, int id)
	{
	}

	[Token(Token = "0x6011A25")]
	[Address(RVA = "0x23D7008", Offset = "0x23D7008", VA = "0x23D7008")]
	public void SetEmptyUIData()
	{
	}

	[Token(Token = "0x6011A26")]
	[Address(RVA = "0x23D7350", Offset = "0x23D7350", VA = "0x23D7350")]
	public RoomPlayerInfo ConstructPlayerInfo()
	{
		return null;
	}

	[Token(Token = "0x6011A28")]
	[Address(RVA = "0x23D7588", Offset = "0x23D7588", VA = "0x23D7588")]
	private void _003COnItemClick_003Em__0()
	{
	}

	[Token(Token = "0x6011A29")]
	[Address(RVA = "0x23D7590", Offset = "0x23D7590", VA = "0x23D7590")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
