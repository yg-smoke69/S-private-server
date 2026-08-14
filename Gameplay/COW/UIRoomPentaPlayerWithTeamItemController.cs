using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002AF9")]
public class UIRoomPentaPlayerWithTeamItemController : UIEasyListItemController
{
	[Token(Token = "0x40107CB")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomPentaPlayerWithTeamItemView m_View;

	[Token(Token = "0x40107CC")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomPlayerInfo> m_Members;

	[Token(Token = "0x40107CD")]
	[FieldOffset(Offset = "0x40")]
	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	[Token(Token = "0x40107CE")]
	[FieldOffset(Offset = "0x44")]
	private int m_Index;

	[Token(Token = "0x6011A39")]
	[Address(RVA = "0x23DA34C", Offset = "0x23DA34C", VA = "0x23DA34C")]
	public UIRoomPentaPlayerWithTeamItemController()
	{
	}

	[Token(Token = "0x6011A3A")]
	[Address(RVA = "0x23DA3D8", Offset = "0x23DA3D8", VA = "0x23DA3D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A3B")]
	[Address(RVA = "0x23DA47C", Offset = "0x23DA47C", VA = "0x23DA47C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A3C")]
	[Address(RVA = "0x23DA9C4", Offset = "0x23DA9C4", VA = "0x23DA9C4")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011A3D")]
	[Address(RVA = "0x23DAB40", Offset = "0x23DAB40", VA = "0x23DAB40", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011A3E")]
	[Address(RVA = "0x23DAC74", Offset = "0x23DAC74", VA = "0x23DAC74", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011A3F")]
	[Address(RVA = "0x23DB7D0", Offset = "0x23DB7D0", VA = "0x23DB7D0")]
	private void OnSelectedChanged(object[] data)
	{
	}

	[Token(Token = "0x6011A40")]
	[Address(RVA = "0x23DB940", Offset = "0x23DB940", VA = "0x23DB940")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011A41")]
	[Address(RVA = "0x23DB948", Offset = "0x23DB948", VA = "0x23DB948")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
