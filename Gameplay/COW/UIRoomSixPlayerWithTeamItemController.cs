using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002B04")]
public class UIRoomSixPlayerWithTeamItemController : UIEasyListItemController
{
	[Token(Token = "0x4010805")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomSixPlayerWithTeamItemView m_View;

	[Token(Token = "0x4010806")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomPlayerInfo> m_Members;

	[Token(Token = "0x4010807")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x4010808")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x6011AA0")]
	[Address(RVA = "0x2BED720", Offset = "0x2BED720", VA = "0x2BED720")]
	public UIRoomSixPlayerWithTeamItemController()
	{
	}

	[Token(Token = "0x6011AA1")]
	[Address(RVA = "0x2BED7AC", Offset = "0x2BED7AC", VA = "0x2BED7AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011AA2")]
	[Address(RVA = "0x2BED850", Offset = "0x2BED850", VA = "0x2BED850", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011AA3")]
	[Address(RVA = "0x2BEDE54", Offset = "0x2BEDE54", VA = "0x2BEDE54")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011AA4")]
	[Address(RVA = "0x2BEDFD0", Offset = "0x2BEDFD0", VA = "0x2BEDFD0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011AA5")]
	[Address(RVA = "0x2BEE104", Offset = "0x2BEE104", VA = "0x2BEE104", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011AA6")]
	[Address(RVA = "0x2BEEC18", Offset = "0x2BEEC18", VA = "0x2BEEC18")]
	private void OnSelectedChanged(object[] data)
	{
	}

	[Token(Token = "0x6011AA7")]
	[Address(RVA = "0x2BEED88", Offset = "0x2BEED88", VA = "0x2BEED88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011AA8")]
	[Address(RVA = "0x2BEED90", Offset = "0x2BEED90", VA = "0x2BEED90")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
