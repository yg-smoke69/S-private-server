using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002889")]
internal class UIHudTreasureMapController : UIHudButtonBaseController
{
	[Token(Token = "0x400F9A2")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudTreasureMapView m_View;

	[Token(Token = "0x400F9A3")]
	[FieldOffset(Offset = "0x30")]
	private bool needShow;

	[Token(Token = "0x400F9A4")]
	[FieldOffset(Offset = "0x31")]
	private bool HasShownTutorial;

	[Token(Token = "0x600FE4E")]
	[Address(RVA = "0x1588AB0", Offset = "0x1588AB0", VA = "0x1588AB0")]
	public UIHudTreasureMapController()
	{
	}

	[Token(Token = "0x600FE4F")]
	[Address(RVA = "0x1588AB8", Offset = "0x1588AB8", VA = "0x1588AB8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FE50")]
	[Address(RVA = "0x1588B5C", Offset = "0x1588B5C", VA = "0x1588B5C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FE51")]
	[Address(RVA = "0x1588DB4", Offset = "0x1588DB4", VA = "0x1588DB4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FE52")]
	[Address(RVA = "0x1588FB8", Offset = "0x1588FB8", VA = "0x1588FB8", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FE53")]
	[Address(RVA = "0x158905C", Offset = "0x158905C", VA = "0x158905C")]
	private void ShowTreasureMapIcon(object[] param)
	{
	}

	[Token(Token = "0x600FE54")]
	[Address(RVA = "0x1589398", Offset = "0x1589398", VA = "0x1589398")]
	private bool ShouldShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600FE55")]
	[Address(RVA = "0x15895C0", Offset = "0x15895C0", VA = "0x15895C0")]
	private void OnUpdateLoadoutCount(object[] param)
	{
	}

	[Token(Token = "0x600FE56")]
	[Address(RVA = "0x15897C4", Offset = "0x15897C4", VA = "0x15897C4")]
	private void OnGameOpenningEnd(object[] param)
	{
	}

	[Token(Token = "0x600FE57")]
	[Address(RVA = "0x158993C", Offset = "0x158993C", VA = "0x158993C")]
	private void ShowTutorial()
	{
	}

	[Token(Token = "0x600FE58")]
	[Address(RVA = "0x1589B44", Offset = "0x1589B44", VA = "0x1589B44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FE59")]
	[Address(RVA = "0x1589B4C", Offset = "0x1589B4C", VA = "0x1589B4C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
