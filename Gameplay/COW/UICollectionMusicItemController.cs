using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002572")]
public class UICollectionMusicItemController : UIEasyListItemController
{
	[Token(Token = "0x400E7C2")]
	[FieldOffset(Offset = "0x38")]
	private UICollectionMusicItemView m_View;

	[Token(Token = "0x400E7C3")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_ItemIconGrey;

	[Token(Token = "0x400E7C4")]
	[FieldOffset(Offset = "0x40")]
	private bool m_CollectionABReady;

	[Token(Token = "0x400E7C5")]
	[FieldOffset(Offset = "0x44")]
	private MusicData m_MusicData;

	[Token(Token = "0x400E7C6")]
	[FieldOffset(Offset = "0x48")]
	private UINewVaultItemViewData m_Data;

	[Token(Token = "0x600DADF")]
	[Address(RVA = "0x2CD3814", Offset = "0x2CD3814", VA = "0x2CD3814")]
	public UICollectionMusicItemController()
	{
	}

	[Token(Token = "0x600DAE0")]
	[Address(RVA = "0x2CD3828", Offset = "0x2CD3828", VA = "0x2CD3828")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DAE1")]
	[Address(RVA = "0x2CD38CC", Offset = "0x2CD38CC", VA = "0x2CD38CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DAE2")]
	[Address(RVA = "0x2CD3A28", Offset = "0x2CD3A28", VA = "0x2CD3A28", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600DAE3")]
	[Address(RVA = "0x2CD426C", Offset = "0x2CD426C", VA = "0x2CD426C")]
	private void SetCornerIconTag()
	{
	}

	[Token(Token = "0x600DAE4")]
	[Address(RVA = "0x2CD466C", Offset = "0x2CD466C", VA = "0x2CD466C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600DAE5")]
	[Address(RVA = "0x2CD4774", Offset = "0x2CD4774", VA = "0x2CD4774")]
	public void RefreshEquipState()
	{
	}

	[Token(Token = "0x600DAE6")]
	[Address(RVA = "0x2CD4850", Offset = "0x2CD4850", VA = "0x2CD4850")]
	public void RefreshABReady()
	{
	}

	[Token(Token = "0x600DAE7")]
	[Address(RVA = "0x2CD4AC8", Offset = "0x2CD4AC8", VA = "0x2CD4AC8", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600DAE8")]
	[Address(RVA = "0x2CD4B64", Offset = "0x2CD4B64", VA = "0x2CD4B64")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DAE9")]
	[Address(RVA = "0x2CD4B6C", Offset = "0x2CD4B6C", VA = "0x2CD4B6C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600DAEA")]
	[Address(RVA = "0x2CD4B74", Offset = "0x2CD4B74", VA = "0x2CD4B74")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
