using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002562")]
public class UIClanWarNewsRewardItemController : UIBaseController
{
	[Token(Token = "0x400E775")]
	[FieldOffset(Offset = "0x28")]
	private UIClanWarNewsRewardItemView m_View;

	[Token(Token = "0x400E776")]
	[FieldOffset(Offset = "0x2C")]
	private List<BaseItemInfo> m_ItemList;

	[Token(Token = "0x600DA49")]
	[Address(RVA = "0x2902E6C", Offset = "0x2902E6C", VA = "0x2902E6C")]
	public UIClanWarNewsRewardItemController()
	{
	}

	[Token(Token = "0x600DA4A")]
	[Address(RVA = "0x2902EF0", Offset = "0x2902EF0", VA = "0x2902EF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA4B")]
	[Address(RVA = "0x2902F98", Offset = "0x2902F98", VA = "0x2902F98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA4C")]
	[Address(RVA = "0x2903004", Offset = "0x2903004", VA = "0x2903004")]
	private void InitView()
	{
	}

	[Token(Token = "0x600DA4D")]
	[Address(RVA = "0x2903154", Offset = "0x2903154", VA = "0x2903154")]
	public void SetItemData(uint rewardId)
	{
	}

	[Token(Token = "0x600DA4E")]
	[Address(RVA = "0x29034AC", Offset = "0x29034AC", VA = "0x29034AC")]
	public void SetItemData(List<AwardDesc> reward)
	{
	}

	[Token(Token = "0x600DA4F")]
	[Address(RVA = "0x29036D4", Offset = "0x29036D4", VA = "0x29036D4")]
	public void SetIconSprite(string spriteName, bool snap = true)
	{
	}

	[Token(Token = "0x600DA50")]
	[Address(RVA = "0x29037CC", Offset = "0x29037CC", VA = "0x29037CC")]
	private void OnClickItem()
	{
	}

	[Token(Token = "0x600DA51")]
	[Address(RVA = "0x2903AEC", Offset = "0x2903AEC", VA = "0x2903AEC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
