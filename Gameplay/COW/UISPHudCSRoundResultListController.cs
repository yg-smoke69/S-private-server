using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B31")]
internal class UISPHudCSRoundResultListController : UIBaseController
{
	[Token(Token = "0x401092C")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudCSRoundResultListView m_View;

	[Token(Token = "0x401092D")]
	[FieldOffset(Offset = "0x2C")]
	private OAINDKGMHJK mGame;

	[Token(Token = "0x401092E")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsShow;

	[Token(Token = "0x401092F")]
	[FieldOffset(Offset = "0x34")]
	private List<UISPHudCSRoundResultItemController> mRoundItems;

	[Token(Token = "0x6011C67")]
	[Address(RVA = "0x1D17A20", Offset = "0x1D17A20", VA = "0x1D17A20")]
	public UISPHudCSRoundResultListController()
	{
	}

	[Token(Token = "0x6011C68")]
	[Address(RVA = "0x1D17AE0", Offset = "0x1D17AE0", VA = "0x1D17AE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011C69")]
	[Address(RVA = "0x1D17B88", Offset = "0x1D17B88", VA = "0x1D17B88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011C6A")]
	[Address(RVA = "0x1D17DD8", Offset = "0x1D17DD8", VA = "0x1D17DD8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6011C6B")]
	[Address(RVA = "0x1D17F58", Offset = "0x1D17F58", VA = "0x1D17F58", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011C6C")]
	[Address(RVA = "0x1D1815C", Offset = "0x1D1815C", VA = "0x1D1815C")]
	private void OnMaxRoundChanged(object[] data)
	{
	}

	[Token(Token = "0x6011C6D")]
	[Address(RVA = "0x1D1874C", Offset = "0x1D1874C", VA = "0x1D1874C")]
	private void OnRoundResultUpdate(object[] data)
	{
	}

	[Token(Token = "0x6011C6E")]
	[Address(RVA = "0x1D18B44", Offset = "0x1D18B44", VA = "0x1D18B44")]
	private void OnToggleRoundInfo(object[] data)
	{
	}

	[Token(Token = "0x6011C6F")]
	[Address(RVA = "0x1D17E48", Offset = "0x1D17E48", VA = "0x1D17E48")]
	private void OnShowRoundInfo(bool show)
	{
	}

	[Token(Token = "0x6011C70")]
	[Address(RVA = "0x1D18BC0", Offset = "0x1D18BC0", VA = "0x1D18BC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011C71")]
	[Address(RVA = "0x1D18BC8", Offset = "0x1D18BC8", VA = "0x1D18BC8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6011C72")]
	[Address(RVA = "0x1D18BD0", Offset = "0x1D18BD0", VA = "0x1D18BD0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
