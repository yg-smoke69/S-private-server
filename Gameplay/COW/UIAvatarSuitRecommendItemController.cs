using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024DC")]
public class UIAvatarSuitRecommendItemController : UIBaseController
{
	[Token(Token = "0x400E485")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarSuitRecommendItemView m_View;

	[Token(Token = "0x400E486")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_SuitID;

	[Token(Token = "0x600D439")]
	[Address(RVA = "0x2FA4D50", Offset = "0x2FA4D50", VA = "0x2FA4D50")]
	public UIAvatarSuitRecommendItemController()
	{
	}

	[Token(Token = "0x600D43A")]
	[Address(RVA = "0x2FA4DD4", Offset = "0x2FA4DD4", VA = "0x2FA4DD4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D43B")]
	[Address(RVA = "0x2FA4E78", Offset = "0x2FA4E78", VA = "0x2FA4E78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D43C")]
	[Address(RVA = "0x2FA5048", Offset = "0x2FA5048", VA = "0x2FA5048", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D43D")]
	[Address(RVA = "0x2FA50AC", Offset = "0x2FA50AC", VA = "0x2FA50AC")]
	private void OnCloseClick()
	{
	}

	[Token(Token = "0x600D43E")]
	[Address(RVA = "0x2FA5110", Offset = "0x2FA5110", VA = "0x2FA5110")]
	private void OnPurchaseClick()
	{
	}

	[Token(Token = "0x600D43F")]
	[Address(RVA = "0x2FA5A14", Offset = "0x2FA5A14", VA = "0x2FA5A14")]
	public void RefreshData(uint suitId)
	{
	}

	[Token(Token = "0x600D440")]
	[Address(RVA = "0x2FA5DC4", Offset = "0x2FA5DC4", VA = "0x2FA5DC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D441")]
	[Address(RVA = "0x2FA5DCC", Offset = "0x2FA5DCC", VA = "0x2FA5DCC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
