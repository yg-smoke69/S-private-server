using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002AE5")]
public class UIRoomDuoPlayerItemController : UIEasyListItemController
{
	[Token(Token = "0x4010765")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomDuoPlayerItemView m_View;

	[Token(Token = "0x4010766")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomPlayerInfo> m_Members;

	[Token(Token = "0x4010767")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x4010768")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x601197F")]
	[Address(RVA = "0x23BE2E0", Offset = "0x23BE2E0", VA = "0x23BE2E0")]
	public UIRoomDuoPlayerItemController()
	{
	}

	[Token(Token = "0x6011980")]
	[Address(RVA = "0x23BE36C", Offset = "0x23BE36C", VA = "0x23BE36C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011981")]
	[Address(RVA = "0x23BE410", Offset = "0x23BE410", VA = "0x23BE410", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011982")]
	[Address(RVA = "0x23BE690", Offset = "0x23BE690", VA = "0x23BE690")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011983")]
	[Address(RVA = "0x23BE80C", Offset = "0x23BE80C", VA = "0x23BE80C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011984")]
	[Address(RVA = "0x23BEBE4", Offset = "0x23BEBE4", VA = "0x23BEBE4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
