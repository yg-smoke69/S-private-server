using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A10")]
public class UIPayItemController : UIBaseController
{
	[Token(Token = "0x40102BD")]
	[FieldOffset(Offset = "0x28")]
	private UIPayItemView m_View;

	[Token(Token = "0x40102BE")]
	[FieldOffset(Offset = "0x2C")]
	private PayItemData m_Data;

	[Token(Token = "0x40102BF")]
	[FieldOffset(Offset = "0x30")]
	private UIModelPayment m_ModelPayment;

	[Token(Token = "0x40102C0")]
	[FieldOffset(Offset = "0x34")]
	private uint m_DelayCall;

	[Token(Token = "0x6011016")]
	[Address(RVA = "0x15B5B94", Offset = "0x15B5B94", VA = "0x15B5B94")]
	public UIPayItemController()
	{
	}

	[Token(Token = "0x6011017")]
	[Address(RVA = "0x15B5C18", Offset = "0x15B5C18", VA = "0x15B5C18")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011018")]
	[Address(RVA = "0x15B5CBC", Offset = "0x15B5CBC", VA = "0x15B5CBC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011019")]
	[Address(RVA = "0x15B5E88", Offset = "0x15B5E88", VA = "0x15B5E88", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601101A")]
	[Address(RVA = "0x15B6004", Offset = "0x15B6004", VA = "0x15B6004")]
	public void SetDragScrollView(UIScrollView scrollView)
	{
	}

	[Token(Token = "0x601101B")]
	[Address(RVA = "0x15B60F8", Offset = "0x15B60F8", VA = "0x15B60F8")]
	public void SetData(PayItemData data)
	{
	}

	[Token(Token = "0x601101C")]
	[Address(RVA = "0x15B642C", Offset = "0x15B642C", VA = "0x15B642C")]
	private void SetVirtualCurrencyAmount(PayItemData localData, PayItemData remoteData)
	{
	}

	[Token(Token = "0x601101D")]
	[Address(RVA = "0x15B68E8", Offset = "0x15B68E8", VA = "0x15B68E8")]
	private void SetCostString(PayItemData localData, PayItemData remoteData)
	{
	}

	[Token(Token = "0x601101E")]
	[Address(RVA = "0x15B6B4C", Offset = "0x15B6B4C", VA = "0x15B6B4C")]
	private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
	{
	}

	[Token(Token = "0x601101F")]
	[Address(RVA = "0x15B6BF4", Offset = "0x15B6BF4", VA = "0x15B6BF4")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x6011020")]
	[Address(RVA = "0x15B6D78", Offset = "0x15B6D78", VA = "0x15B6D78")]
	public void PlayBounsAnim(int index)
	{
	}

	[Token(Token = "0x6011021")]
	[Address(RVA = "0x15B6EE8", Offset = "0x15B6EE8", VA = "0x15B6EE8")]
	private void PlayAnim()
	{
	}

	[Token(Token = "0x6011022")]
	[Address(RVA = "0x15B5EF4", Offset = "0x15B5EF4", VA = "0x15B5EF4")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x6011023")]
	[Address(RVA = "0x15B6FC0", Offset = "0x15B6FC0", VA = "0x15B6FC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011024")]
	[Address(RVA = "0x15B6FC8", Offset = "0x15B6FC8", VA = "0x15B6FC8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
