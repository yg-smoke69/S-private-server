using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002AFD")]
internal class UIRoomPlayersWithTeamItemController : UIEasyListItemController
{
	[Token(Token = "0x40107E2")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomPlayersWithTeamItemView m_View;

	[Token(Token = "0x40107E3")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomPlayerInfo> m_Members;

	[Token(Token = "0x40107E4")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x40107E5")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x6011A65")]
	[Address(RVA = "0x2BE4DD4", Offset = "0x2BE4DD4", VA = "0x2BE4DD4")]
	public UIRoomPlayersWithTeamItemController()
	{
	}

	[Token(Token = "0x6011A66")]
	[Address(RVA = "0x2BE4E60", Offset = "0x2BE4E60", VA = "0x2BE4E60")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A67")]
	[Address(RVA = "0x2BE4F08", Offset = "0x2BE4F08", VA = "0x2BE4F08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A68")]
	[Address(RVA = "0x2BE5098", Offset = "0x2BE5098", VA = "0x2BE5098")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011A69")]
	[Address(RVA = "0x2BE5214", Offset = "0x2BE5214", VA = "0x2BE5214", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011A6A")]
	[Address(RVA = "0x2BE5348", Offset = "0x2BE5348", VA = "0x2BE5348", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011A6B")]
	[Address(RVA = "0x2BE609C", Offset = "0x2BE609C", VA = "0x2BE609C")]
	private void OnSelectedChanged(object[] data)
	{
	}

	[Token(Token = "0x6011A6C")]
	[Address(RVA = "0x2BE620C", Offset = "0x2BE620C", VA = "0x2BE620C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011A6D")]
	[Address(RVA = "0x2BE6214", Offset = "0x2BE6214", VA = "0x2BE6214")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
