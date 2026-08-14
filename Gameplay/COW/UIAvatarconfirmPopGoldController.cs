using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024A5")]
public class UIAvatarconfirmPopGoldController : UIPopupWindowController
{
	[Token(Token = "0x400E318")]
	[FieldOffset(Offset = "0x48")]
	private UIAvatarConfirmPopDiamondView m_View;

	[Token(Token = "0x400E319")]
	[FieldOffset(Offset = "0x4C")]
	private UIAvatarConfirmPopController m_OtherCtrl;

	[Token(Token = "0x400E31A")]
	[FieldOffset(Offset = "0x50")]
	private uint buyid;

	[Token(Token = "0x400E31B")]
	[FieldOffset(Offset = "0x54")]
	private uint m_Interval;

	[Token(Token = "0x400E31C")]
	[FieldOffset(Offset = "0x58")]
	private uint m_PriceGem;

	[Token(Token = "0x400E31D")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_cnt;

	[Token(Token = "0x400E31E")]
	[FieldOffset(Offset = "0x60")]
	private uint m_AvatarId;

	[Token(Token = "0x600D1B1")]
	[Address(RVA = "0x13FDF88", Offset = "0x13FDF88", VA = "0x13FDF88")]
	public UIAvatarconfirmPopGoldController()
	{
	}

	[Token(Token = "0x600D1B2")]
	[Address(RVA = "0x13FDF90", Offset = "0x13FDF90", VA = "0x13FDF90")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D1B3")]
	[Address(RVA = "0x13FE038", Offset = "0x13FE038", VA = "0x13FE038", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D1B4")]
	[Address(RVA = "0x13FE208", Offset = "0x13FE208", VA = "0x13FE208")]
	private void OnBuy()
	{
	}

	[Token(Token = "0x600D1B5")]
	[Address(RVA = "0x13FE394", Offset = "0x13FE394", VA = "0x13FE394")]
	public void SetData(UIAvatarConfirmPopController ctrl, uint id, uint itemCount, uint itemInterval, uint price, uint avatarid)
	{
	}

	[Token(Token = "0x600D1B6")]
	[Address(RVA = "0x13FE5D0", Offset = "0x13FE5D0", VA = "0x13FE5D0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D1B7")]
	[Address(RVA = "0x13FE63C", Offset = "0x13FE63C", VA = "0x13FE63C")]
	private void _003COnBuy_003Em__0()
	{
	}

	[Token(Token = "0x600D1B8")]
	[Address(RVA = "0x13FE7A4", Offset = "0x13FE7A4", VA = "0x13FE7A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D1B9")]
	[Address(RVA = "0x13FE7AC", Offset = "0x13FE7AC", VA = "0x13FE7AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
