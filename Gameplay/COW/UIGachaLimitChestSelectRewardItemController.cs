using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200265A")]
public class UIGachaLimitChestSelectRewardItemController : UIGachaLimitItemController
{
	[Token(Token = "0x400ECE4")]
	[FieldOffset(Offset = "0x40")]
	private Action<int> m_onClickFunc;

	[Token(Token = "0x400ECE5")]
	[FieldOffset(Offset = "0x44")]
	private bool m_bIsSelected;

	[Token(Token = "0x400ECE6")]
	[FieldOffset(Offset = "0x48")]
	private uint m_itemID;

	[Token(Token = "0x600E52F")]
	[Address(RVA = "0x2E8600C", Offset = "0x2E8600C", VA = "0x2E8600C")]
	public UIGachaLimitChestSelectRewardItemController()
	{
	}

	[Token(Token = "0x600E530")]
	[Address(RVA = "0x2E86014", Offset = "0x2E86014", VA = "0x2E86014")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E531")]
	[Address(RVA = "0x2E860BC", Offset = "0x2E860BC", VA = "0x2E860BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E532")]
	[Address(RVA = "0x2E86178", Offset = "0x2E86178", VA = "0x2E86178")]
	protected void OnBtnTipClick()
	{
	}

	[Token(Token = "0x600E533")]
	[Address(RVA = "0x2E7A1A4", Offset = "0x2E7A1A4", VA = "0x2E7A1A4")]
	public void InitOnClickFunc([Optional] Action<int> onClick)
	{
	}

	[Token(Token = "0x600E534")]
	[Address(RVA = "0x2E7EE44", Offset = "0x2E7EE44", VA = "0x2E7EE44")]
	public void RefreshState()
	{
	}

	[Token(Token = "0x600E535")]
	[Address(RVA = "0x2E7E850", Offset = "0x2E7E850", VA = "0x2E7E850")]
	public void SetViewData(uint gachaID, int idx, GachaShowItem info)
	{
	}

	[Token(Token = "0x600E536")]
	[Address(RVA = "0x2E86230", Offset = "0x2E86230", VA = "0x2E86230")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
