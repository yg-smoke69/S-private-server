using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024A4")]
public class UIAvatarconfirmPopDiamondController : UIPopupWindowController
{
	[Token(Token = "0x400E311")]
	[FieldOffset(Offset = "0x48")]
	private UIAvatarConfirmPopDiamondView m_View;

	[Token(Token = "0x400E312")]
	[FieldOffset(Offset = "0x4C")]
	private UIAvatarConfirmPopController m_OtherCtrl;

	[Token(Token = "0x400E313")]
	[FieldOffset(Offset = "0x50")]
	private uint buyid;

	[Token(Token = "0x400E314")]
	[FieldOffset(Offset = "0x54")]
	private uint m_Interval;

	[Token(Token = "0x400E315")]
	[FieldOffset(Offset = "0x58")]
	private uint m_PriceGem;

	[Token(Token = "0x400E316")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_cnt;

	[Token(Token = "0x400E317")]
	[FieldOffset(Offset = "0x60")]
	private uint m_AvatarId;

	[Token(Token = "0x600D1A8")]
	[Address(RVA = "0x13FD75C", Offset = "0x13FD75C", VA = "0x13FD75C")]
	public UIAvatarconfirmPopDiamondController()
	{
	}

	[Token(Token = "0x600D1A9")]
	[Address(RVA = "0x13FD764", Offset = "0x13FD764", VA = "0x13FD764")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D1AA")]
	[Address(RVA = "0x13FD80C", Offset = "0x13FD80C", VA = "0x13FD80C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D1AB")]
	[Address(RVA = "0x13FD9DC", Offset = "0x13FD9DC", VA = "0x13FD9DC")]
	private void OnBuy()
	{
	}

	[Token(Token = "0x600D1AC")]
	[Address(RVA = "0x13FDB68", Offset = "0x13FDB68", VA = "0x13FDB68")]
	public void SetData(UIAvatarConfirmPopController ctrl, uint id, uint itemCount, uint itemInterval, uint price, uint avatarid)
	{
	}

	[Token(Token = "0x600D1AD")]
	[Address(RVA = "0x13FDDA4", Offset = "0x13FDDA4", VA = "0x13FDDA4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D1AE")]
	[Address(RVA = "0x13FDE10", Offset = "0x13FDE10", VA = "0x13FDE10")]
	private void _003COnBuy_003Em__0()
	{
	}

	[Token(Token = "0x600D1AF")]
	[Address(RVA = "0x13FDF78", Offset = "0x13FDF78", VA = "0x13FDF78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D1B0")]
	[Address(RVA = "0x13FDF80", Offset = "0x13FDF80", VA = "0x13FDF80")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
