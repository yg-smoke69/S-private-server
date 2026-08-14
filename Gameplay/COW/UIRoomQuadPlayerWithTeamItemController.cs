using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002B00")]
public class UIRoomQuadPlayerWithTeamItemController : UIEasyListItemController
{
	[Token(Token = "0x40107F7")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomQuadPlayerWithTeamItemView m_View;

	[Token(Token = "0x40107F8")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomPlayerInfo> m_Members;

	[Token(Token = "0x40107F9")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x40107FA")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x6011A82")]
	[Address(RVA = "0x2BE92D0", Offset = "0x2BE92D0", VA = "0x2BE92D0")]
	public UIRoomQuadPlayerWithTeamItemController()
	{
	}

	[Token(Token = "0x6011A83")]
	[Address(RVA = "0x2BE935C", Offset = "0x2BE935C", VA = "0x2BE935C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A84")]
	[Address(RVA = "0x2BE9400", Offset = "0x2BE9400", VA = "0x2BE9400", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A85")]
	[Address(RVA = "0x2BE98E4", Offset = "0x2BE98E4", VA = "0x2BE98E4")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011A86")]
	[Address(RVA = "0x2BE9A60", Offset = "0x2BE9A60", VA = "0x2BE9A60", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011A87")]
	[Address(RVA = "0x2BE9B94", Offset = "0x2BE9B94", VA = "0x2BE9B94", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011A88")]
	[Address(RVA = "0x2BEA788", Offset = "0x2BEA788", VA = "0x2BEA788")]
	private void OnSelectedChanged(object[] data)
	{
	}

	[Token(Token = "0x6011A89")]
	[Address(RVA = "0x2BEA8F8", Offset = "0x2BEA8F8", VA = "0x2BEA8F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011A8A")]
	[Address(RVA = "0x2BEA900", Offset = "0x2BEA900", VA = "0x2BEA900")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
