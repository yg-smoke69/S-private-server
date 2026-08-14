using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002796")]
internal class UIHudItemMarkShowItemController : UIBaseController
{
	[Token(Token = "0x400F47E")]
	[FieldOffset(Offset = "0x28")]
	private UIHudItemMarkShowItemView m_View;

	[Token(Token = "0x400F47F")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_ItemId;

	[Token(Token = "0x400F480")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 ItemPosition;

	[Token(Token = "0x600F3F0")]
	[Address(RVA = "0x20ABE64", Offset = "0x20ABE64", VA = "0x20ABE64")]
	public UIHudItemMarkShowItemController()
	{
	}

	[Token(Token = "0x600F3F1")]
	[Address(RVA = "0x20ABEE8", Offset = "0x20ABEE8", VA = "0x20ABEE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F3F2")]
	[Address(RVA = "0x20ABF8C", Offset = "0x20ABF8C", VA = "0x20ABF8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F3F3")]
	[Address(RVA = "0x20A9010", Offset = "0x20A9010", VA = "0x20A9010")]
	public void RefreshItemInfo(uint dataID, uint Count, Vector3 Position)
	{
	}

	[Token(Token = "0x600F3F4")]
	[Address(RVA = "0x20AC0E8", Offset = "0x20AC0E8", VA = "0x20AC0E8")]
	private void OnClickItemMark()
	{
	}

	[Token(Token = "0x600F3F5")]
	[Address(RVA = "0x20AC374", Offset = "0x20AC374", VA = "0x20AC374")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
