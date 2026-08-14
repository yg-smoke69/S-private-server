using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200268B")]
internal class URankCardTipsItemController : UIBaseController
{
	[Token(Token = "0x400EDE1")]
	[FieldOffset(Offset = "0x28")]
	private UICouponTipsItemView m_View;

	[Token(Token = "0x400EDE2")]
	[FieldOffset(Offset = "0x2C")]
	private UIStandardItemMiniController m_ItemController;

	[Token(Token = "0x400EDE3")]
	[FieldOffset(Offset = "0x30")]
	private UICountDownController m_Ctrl;

	[Token(Token = "0x600E762")]
	[Address(RVA = "0x1A38648", Offset = "0x1A38648", VA = "0x1A38648")]
	public URankCardTipsItemController()
	{
	}

	[Token(Token = "0x600E763")]
	[Address(RVA = "0x1A386CC", Offset = "0x1A386CC", VA = "0x1A386CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E764")]
	[Address(RVA = "0x1A38774", Offset = "0x1A38774", VA = "0x1A38774", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E765")]
	[Address(RVA = "0x1A38830", Offset = "0x1A38830", VA = "0x1A38830")]
	public void SetData(Item item)
	{
	}

	[Token(Token = "0x600E766")]
	[Address(RVA = "0x1A38CF4", Offset = "0x1A38CF4", VA = "0x1A38CF4")]
	private void _003CSetData_003Em__0()
	{
	}

	[Token(Token = "0x600E767")]
	[Address(RVA = "0x1A38D28", Offset = "0x1A38D28", VA = "0x1A38D28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
