using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C29")]
internal class UIWorkshopMapItemController : UIBaseController
{
	[Token(Token = "0x4010DB0")]
	[FieldOffset(Offset = "0x28")]
	private UIWorkshopMapItemView m_View;

	[Token(Token = "0x4010DB1")]
	[FieldOffset(Offset = "0x2C")]
	public int ItemIdx;

	[Token(Token = "0x4010DB2")]
	[FieldOffset(Offset = "0x30")]
	private Action m_ClickCallBack;

	[Token(Token = "0x6012651")]
	[Address(RVA = "0x1A335F8", Offset = "0x1A335F8", VA = "0x1A335F8")]
	public UIWorkshopMapItemController()
	{
	}

	[Token(Token = "0x6012652")]
	[Address(RVA = "0x1A3367C", Offset = "0x1A3367C", VA = "0x1A3367C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012653")]
	[Address(RVA = "0x1A33724", Offset = "0x1A33724", VA = "0x1A33724", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012654")]
	[Address(RVA = "0x1A338E8", Offset = "0x1A338E8", VA = "0x1A338E8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6012655")]
	[Address(RVA = "0x1A3394C", Offset = "0x1A3394C", VA = "0x1A3394C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012656")]
	[Address(RVA = "0x1A339B0", Offset = "0x1A339B0", VA = "0x1A339B0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012657")]
	[Address(RVA = "0x1A1A678", Offset = "0x1A1A678", VA = "0x1A1A678")]
	public void SetUISize(int width, int height)
	{
	}

	[Token(Token = "0x6012658")]
	[Address(RVA = "0x1A1B06C", Offset = "0x1A1B06C", VA = "0x1A1B06C")]
	public void SetCDNData(string url)
	{
	}

	[Token(Token = "0x6012659")]
	[Address(RVA = "0x1A1AD0C", Offset = "0x1A1AD0C", VA = "0x1A1AD0C")]
	public void SetGameMapData(uint mapID, byte[] bitMapData, byte[] iconMapData)
	{
	}

	[Token(Token = "0x601265A")]
	[Address(RVA = "0x1A1B00C", Offset = "0x1A1B00C", VA = "0x1A1B00C")]
	public void SetBtnClick(Action callback)
	{
	}

	[Token(Token = "0x601265B")]
	[Address(RVA = "0x1A1BA04", Offset = "0x1A1BA04", VA = "0x1A1BA04")]
	public void OnClick()
	{
	}

	[Token(Token = "0x601265C")]
	[Address(RVA = "0x1A33A58", Offset = "0x1A33A58", VA = "0x1A33A58")]
	private void _003CSetCDNData_003Em__0()
	{
	}

	[Token(Token = "0x601265D")]
	[Address(RVA = "0x1A33B38", Offset = "0x1A33B38", VA = "0x1A33B38")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601265E")]
	[Address(RVA = "0x1A33B40", Offset = "0x1A33B40", VA = "0x1A33B40")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x601265F")]
	[Address(RVA = "0x1A33B48", Offset = "0x1A33B48", VA = "0x1A33B48")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6012660")]
	[Address(RVA = "0x1A33B50", Offset = "0x1A33B50", VA = "0x1A33B50")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
