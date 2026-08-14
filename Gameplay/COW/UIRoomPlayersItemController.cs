using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002AFC")]
public class UIRoomPlayersItemController : UIEasyListItemController
{
	[Token(Token = "0x40107DE")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomPlayersItemView m_View;

	[Token(Token = "0x40107DF")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomPlayerInfo> m_Members;

	[Token(Token = "0x40107E0")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x40107E1")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x6011A5C")]
	[Address(RVA = "0x2BE3D14", Offset = "0x2BE3D14", VA = "0x2BE3D14")]
	public UIRoomPlayersItemController()
	{
	}

	[Token(Token = "0x6011A5D")]
	[Address(RVA = "0x2BE3DA0", Offset = "0x2BE3DA0", VA = "0x2BE3DA0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A5E")]
	[Address(RVA = "0x2BE3E48", Offset = "0x2BE3E48", VA = "0x2BE3E48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A5F")]
	[Address(RVA = "0x2BE3FD8", Offset = "0x2BE3FD8", VA = "0x2BE3FD8")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011A60")]
	[Address(RVA = "0x2BE4154", Offset = "0x2BE4154", VA = "0x2BE4154", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011A61")]
	[Address(RVA = "0x2BE4288", Offset = "0x2BE4288", VA = "0x2BE4288", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011A62")]
	[Address(RVA = "0x2BE48C8", Offset = "0x2BE48C8", VA = "0x2BE48C8")]
	private void OnSelectedChanged(object[] data)
	{
	}

	[Token(Token = "0x6011A63")]
	[Address(RVA = "0x2BE4A38", Offset = "0x2BE4A38", VA = "0x2BE4A38")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011A64")]
	[Address(RVA = "0x2BE4A40", Offset = "0x2BE4A40", VA = "0x2BE4A40")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
