using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200265F")]
public class UIGachaLimitExtraListItemController : UIBaseController
{
	[Token(Token = "0x2002660")]
	public enum ExtraAwardItemState
	{
		[Token(Token = "0x400ED0D")]
		STATE_NONE,
		[Token(Token = "0x400ED0E")]
		STATE_ALREADY_RECEIVE,
		[Token(Token = "0x400ED0F")]
		STATE_CAN_RECEIVE,
		[Token(Token = "0x400ED10")]
		STATE_CANNOT_RECEIVE
	}

	[Token(Token = "0x400ED04")]
	[FieldOffset(Offset = "0x28")]
	private UIGachaLimitExtraListItemView m_View;

	[Token(Token = "0x400ED05")]
	[FieldOffset(Offset = "0x2C")]
	private UIGachaExtraRewardItemController m_MiniCtrl;

	[Token(Token = "0x400ED06")]
	[FieldOffset(Offset = "0x30")]
	private ExtraAwardItemState m_State;

	[Token(Token = "0x400ED07")]
	[FieldOffset(Offset = "0x34")]
	private bool isChangeCanReceive;

	[Token(Token = "0x400ED08")]
	[FieldOffset(Offset = "0x38")]
	private ExtraRewardDesc m_ItemDesc;

	[Token(Token = "0x400ED09")]
	[FieldOffset(Offset = "0x3C")]
	private int m_Indx;

	[Token(Token = "0x400ED0A")]
	[FieldOffset(Offset = "0x40")]
	private uint m_GachaID;

	[Token(Token = "0x400ED0B")]
	[FieldOffset(Offset = "0x44")]
	private uint m_ItemDelayCall;

	[Token(Token = "0x17001180")]
	public ExtraAwardItemState State
	{
		[Token(Token = "0x600E57A")]
		[Address(RVA = "0x2A11198", Offset = "0x2A11198", VA = "0x2A11198")]
		get
		{
			return default(ExtraAwardItemState);
		}
	}

	[Token(Token = "0x600E579")]
	[Address(RVA = "0x2A11114", Offset = "0x2A11114", VA = "0x2A11114")]
	public UIGachaLimitExtraListItemController()
	{
	}

	[Token(Token = "0x600E57B")]
	[Address(RVA = "0x2A111F0", Offset = "0x2A111F0", VA = "0x2A111F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E57C")]
	[Address(RVA = "0x2A11294", Offset = "0x2A11294", VA = "0x2A11294", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E57D")]
	[Address(RVA = "0x2A113F0", Offset = "0x2A113F0", VA = "0x2A113F0")]
	public void TryShowGainEffect()
	{
	}

	[Token(Token = "0x600E57E")]
	[Address(RVA = "0x2A1148C", Offset = "0x2A1148C", VA = "0x2A1148C")]
	private void InitView()
	{
	}

	[Token(Token = "0x600E57F")]
	[Address(RVA = "0x2A115C4", Offset = "0x2A115C4", VA = "0x2A115C4")]
	public void SetData(ExtraRewardDesc data, int data_index, uint chestID)
	{
	}

	[Token(Token = "0x600E580")]
	[Address(RVA = "0x2A11660", Offset = "0x2A11660", VA = "0x2A11660")]
	public void UpdateItemState()
	{
	}

	[Token(Token = "0x600E581")]
	[Address(RVA = "0x2A11BCC", Offset = "0x2A11BCC", VA = "0x2A11BCC")]
	private void RefreshExtraAwardItem(uint chestID, bool needShowBg)
	{
	}

	[Token(Token = "0x600E582")]
	[Address(RVA = "0x2A128A4", Offset = "0x2A128A4", VA = "0x2A128A4")]
	public void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E583")]
	[Address(RVA = "0x2A1304C", Offset = "0x2A1304C", VA = "0x2A1304C")]
	private void ReOpenBtnClick()
	{
	}

	[Token(Token = "0x600E584")]
	[Address(RVA = "0x2A130E4", Offset = "0x2A130E4", VA = "0x2A130E4")]
	private void PlayExchangeRewardSound()
	{
	}

	[Token(Token = "0x600E585")]
	[Address(RVA = "0x2A131FC", Offset = "0x2A131FC", VA = "0x2A131FC")]
	public uint GetItemCdtValue()
	{
		return default(uint);
	}

	[Token(Token = "0x600E586")]
	[Address(RVA = "0x2A1326C", Offset = "0x2A1326C", VA = "0x2A1326C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E587")]
	[Address(RVA = "0x2A13380", Offset = "0x2A13380", VA = "0x2A13380", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E588")]
	[Address(RVA = "0x2A133E4", Offset = "0x2A133E4", VA = "0x2A133E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E589")]
	[Address(RVA = "0x2A133EC", Offset = "0x2A133EC", VA = "0x2A133EC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E58A")]
	[Address(RVA = "0x2A133F4", Offset = "0x2A133F4", VA = "0x2A133F4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
