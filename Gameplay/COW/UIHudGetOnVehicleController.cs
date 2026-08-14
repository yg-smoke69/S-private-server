using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002763")]
internal abstract class UIHudGetOnVehicleController : UIHudButtonBaseController
{
	[Token(Token = "0x600F0B6")]
	[Address(RVA = "0x1892CAC", Offset = "0x1892CAC", VA = "0x1892CAC")]
	protected UIHudGetOnVehicleController()
	{
	}

	[Token(Token = "0x600F0B7")]
	[Address(RVA = "0x1892E34", Offset = "0x1892E34", VA = "0x1892E34", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F0B8")]
	[Address(RVA = "0x1893E94", Offset = "0x1893E94", VA = "0x1893E94", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F0B9")]
	[Address(RVA = "0x1893264", Offset = "0x1893264", VA = "0x1893264", Slot = "37")]
	protected virtual void OnActionEnter(object[] param)
	{
	}

	[Token(Token = "0x600F0BA")]
	[Address(RVA = "0x189359C", Offset = "0x189359C", VA = "0x189359C", Slot = "38")]
	protected virtual bool ShouldShow(bool driverEmpty, bool passengerEmpty)
	{
		return default(bool);
	}

	[Token(Token = "0x600F0BB")]
	[Address(RVA = "0x1894038", Offset = "0x1894038", VA = "0x1894038")]
	protected void OnActionEnd(object[] param)
	{
	}

	[Token(Token = "0x600F0BC")]
	[Address(RVA = "0x18940AC", Offset = "0x18940AC", VA = "0x18940AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F0BD")]
	[Address(RVA = "0x18940B4", Offset = "0x18940B4", VA = "0x18940B4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
