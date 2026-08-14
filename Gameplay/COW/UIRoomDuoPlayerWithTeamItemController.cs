using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002AE6")]
public class UIRoomDuoPlayerWithTeamItemController : UIEasyListItemController
{
	[Token(Token = "0x4010769")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomDuoPlayerWithTeamItemView m_View;

	[Token(Token = "0x401076A")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomPlayerInfo> m_Members;

	[Token(Token = "0x401076B")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x401076C")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x6011985")]
	[Address(RVA = "0x23BEF00", Offset = "0x23BEF00", VA = "0x23BEF00")]
	public UIRoomDuoPlayerWithTeamItemController()
	{
	}

	[Token(Token = "0x6011986")]
	[Address(RVA = "0x23BEF8C", Offset = "0x23BEF8C", VA = "0x23BEF8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011987")]
	[Address(RVA = "0x23BF030", Offset = "0x23BF030", VA = "0x23BF030", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011988")]
	[Address(RVA = "0x23BF39C", Offset = "0x23BF39C", VA = "0x23BF39C")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011989")]
	[Address(RVA = "0x23BF518", Offset = "0x23BF518", VA = "0x23BF518", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x601198A")]
	[Address(RVA = "0x23BF64C", Offset = "0x23BF64C", VA = "0x23BF64C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x601198B")]
	[Address(RVA = "0x23C015C", Offset = "0x23C015C", VA = "0x23C015C")]
	private void OnSelectedChanged(object[] data)
	{
	}

	[Token(Token = "0x601198C")]
	[Address(RVA = "0x23C02CC", Offset = "0x23C02CC", VA = "0x23C02CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601198D")]
	[Address(RVA = "0x23C02D4", Offset = "0x23C02D4", VA = "0x23C02D4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
