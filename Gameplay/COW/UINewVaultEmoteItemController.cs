using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029FD")]
internal class UINewVaultEmoteItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x4010281")]
	[FieldOffset(Offset = "0x38")]
	private UINewVaultEmoteItemView m_View;

	[Token(Token = "0x4010282")]
	[FieldOffset(Offset = "0x3C")]
	private UINewVaultItemViewData m_data;

	[Token(Token = "0x4010283")]
	[FieldOffset(Offset = "0x40")]
	private bool m_CollectionABReady;

	[Token(Token = "0x4010284")]
	[FieldOffset(Offset = "0x44")]
	private uint m_ItemIconGrey;

	[Token(Token = "0x6010F49")]
	[Address(RVA = "0x2C1F6B0", Offset = "0x2C1F6B0", VA = "0x2C1F6B0")]
	public UINewVaultEmoteItemController()
	{
	}

	[Token(Token = "0x6010F4A")]
	[Address(RVA = "0x2C1F6C4", Offset = "0x2C1F6C4", VA = "0x2C1F6C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010F4B")]
	[Address(RVA = "0x2C1B484", Offset = "0x2C1B484", VA = "0x2C1B484")]
	public int GetEmoteID()
	{
		return default(int);
	}

	[Token(Token = "0x6010F4C")]
	[Address(RVA = "0x2C1F76C", Offset = "0x2C1F76C", VA = "0x2C1F76C")]
	private void SetIPTag()
	{
	}

	[Token(Token = "0x6010F4D")]
	[Address(RVA = "0x2C1FA88", Offset = "0x2C1FA88", VA = "0x2C1FA88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010F4E")]
	[Address(RVA = "0x2C1FE1C", Offset = "0x2C1FE1C", VA = "0x2C1FE1C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010F4F")]
	[Address(RVA = "0x2C1FF98", Offset = "0x2C1FF98", VA = "0x2C1FF98", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6010F50")]
	[Address(RVA = "0x2C20034", Offset = "0x2C20034", VA = "0x2C20034", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010F51")]
	[Address(RVA = "0x2C189B0", Offset = "0x2C189B0", VA = "0x2C189B0")]
	public void RefreshABReady()
	{
	}

	[Token(Token = "0x6010F52")]
	[Address(RVA = "0x2C20C18", Offset = "0x2C20C18", VA = "0x2C20C18")]
	private void SetRankingItemIcon()
	{
	}

	[Token(Token = "0x6010F53")]
	[Address(RVA = "0x2C1F1F4", Offset = "0x2C1F1F4", VA = "0x2C1F1F4")]
	public void OnDragDropRelease(uint slotIndex)
	{
	}

	[Token(Token = "0x6010F54")]
	[Address(RVA = "0x2C21240", Offset = "0x2C21240", VA = "0x2C21240", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010F55")]
	[Address(RVA = "0x2C20F58", Offset = "0x2C20F58", VA = "0x2C20F58")]
	private void RefreshEquipState()
	{
	}

	[Token(Token = "0x6010F56")]
	[Address(RVA = "0x2C2130C", Offset = "0x2C2130C", VA = "0x2C2130C", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010F57")]
	[Address(RVA = "0x2C0F770", Offset = "0x2C0F770", VA = "0x2C0F770")]
	public void RefreshNewGetState()
	{
	}

	[Token(Token = "0x6010F58")]
	[Address(RVA = "0x2C213A0", Offset = "0x2C213A0", VA = "0x2C213A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010F59")]
	[Address(RVA = "0x2C213A8", Offset = "0x2C213A8", VA = "0x2C213A8")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010F5A")]
	[Address(RVA = "0x2C213B0", Offset = "0x2C213B0", VA = "0x2C213B0")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
