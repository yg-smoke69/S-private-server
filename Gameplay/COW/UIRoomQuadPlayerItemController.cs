using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002AFF")]
public class UIRoomQuadPlayerItemController : UIEasyListItemController
{
	[Token(Token = "0x40107F3")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomQuadPlayerItemView m_View;

	[Token(Token = "0x40107F4")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomPlayerInfo> m_Members;

	[Token(Token = "0x40107F5")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x40107F6")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x6011A7C")]
	[Address(RVA = "0x2BE8498", Offset = "0x2BE8498", VA = "0x2BE8498")]
	public UIRoomQuadPlayerItemController()
	{
	}

	[Token(Token = "0x6011A7D")]
	[Address(RVA = "0x2BE8524", Offset = "0x2BE8524", VA = "0x2BE8524")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A7E")]
	[Address(RVA = "0x2BE85C8", Offset = "0x2BE85C8", VA = "0x2BE85C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A7F")]
	[Address(RVA = "0x2BE89C0", Offset = "0x2BE89C0", VA = "0x2BE89C0")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011A80")]
	[Address(RVA = "0x2BE8B3C", Offset = "0x2BE8B3C", VA = "0x2BE8B3C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011A81")]
	[Address(RVA = "0x2BE8F0C", Offset = "0x2BE8F0C", VA = "0x2BE8F0C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
