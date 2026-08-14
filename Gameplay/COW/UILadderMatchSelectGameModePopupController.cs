using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002176")]
public class UILadderMatchSelectGameModePopupController : UIPopupWindowController
{
	[Token(Token = "0x400D20F")]
	[FieldOffset(Offset = "0x48")]
	private UILadderMatchSelectGameModePopupView m_View;

	[Token(Token = "0x400D210")]
	[FieldOffset(Offset = "0x4C")]
	private List<UILadderMatchSelectGameModeItemController> m_ListModes;

	[Token(Token = "0x600B152")]
	[Address(RVA = "0x22D7E34", Offset = "0x22D7E34", VA = "0x22D7E34")]
	public UILadderMatchSelectGameModePopupController()
	{
	}

	[Token(Token = "0x600B153")]
	[Address(RVA = "0x22D7EC0", Offset = "0x22D7EC0", VA = "0x22D7EC0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B154")]
	[Address(RVA = "0x22D80DC", Offset = "0x22D80DC", VA = "0x22D80DC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600B155")]
	[Address(RVA = "0x22D8388", Offset = "0x22D8388", VA = "0x22D8388")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B156")]
	[Address(RVA = "0x22D842C", Offset = "0x22D842C", VA = "0x22D842C")]
	public void SetViewData(List<LadderMatchSelectMode> selectModes)
	{
	}

	[Token(Token = "0x600B157")]
	[Address(RVA = "0x22D8148", Offset = "0x22D8148", VA = "0x22D8148")]
	private void ClearGameModeItems()
	{
	}

	[Token(Token = "0x600B158")]
	[Address(RVA = "0x22D8930", Offset = "0x22D8930", VA = "0x22D8930")]
	private void OnSelectGameMode(object[] data)
	{
	}

	[Token(Token = "0x600B159")]
	[Address(RVA = "0x22D899C", Offset = "0x22D899C", VA = "0x22D899C")]
	private void OnClickBtnClose()
	{
	}

	[Token(Token = "0x600B15A")]
	[Address(RVA = "0x22D8A00", Offset = "0x22D8A00", VA = "0x22D8A00")]
	private void OnClickBtnMask()
	{
	}

	[Token(Token = "0x600B15B")]
	[Address(RVA = "0x22D8A64", Offset = "0x22D8A64", VA = "0x22D8A64")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B15C")]
	[Address(RVA = "0x22D8A6C", Offset = "0x22D8A6C", VA = "0x22D8A6C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
