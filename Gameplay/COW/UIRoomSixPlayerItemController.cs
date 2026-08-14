using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002B03")]
public class UIRoomSixPlayerItemController : UIEasyListItemController
{
	[Token(Token = "0x4010801")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomSixPlayerItemView m_View;

	[Token(Token = "0x4010802")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomPlayerInfo> m_Members;

	[Token(Token = "0x4010803")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x4010804")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x6011A9A")]
	[Address(RVA = "0x2BEC6C8", Offset = "0x2BEC6C8", VA = "0x2BEC6C8")]
	public UIRoomSixPlayerItemController()
	{
	}

	[Token(Token = "0x6011A9B")]
	[Address(RVA = "0x2BEC754", Offset = "0x2BEC754", VA = "0x2BEC754")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A9C")]
	[Address(RVA = "0x2BEC7F8", Offset = "0x2BEC7F8", VA = "0x2BEC7F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A9D")]
	[Address(RVA = "0x2BECD68", Offset = "0x2BECD68", VA = "0x2BECD68")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011A9E")]
	[Address(RVA = "0x2BECEE4", Offset = "0x2BECEE4", VA = "0x2BECEE4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011A9F")]
	[Address(RVA = "0x2BED2B4", Offset = "0x2BED2B4", VA = "0x2BED2B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
