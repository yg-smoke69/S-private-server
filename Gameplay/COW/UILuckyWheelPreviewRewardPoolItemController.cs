using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002963")]
public class UILuckyWheelPreviewRewardPoolItemController : UIEasyListItemController
{
	[Token(Token = "0x400FF1D")]
	[FieldOffset(Offset = "0x38")]
	private UILuckyWheelPreviewRewardPoolItemView m_View;

	[Token(Token = "0x400FF1E")]
	[FieldOffset(Offset = "0x3C")]
	private BaseItemInfo m_Data;

	[Token(Token = "0x400FF1F")]
	[FieldOffset(Offset = "0x40")]
	private UIModelLuckyWheel m_Model;

	[Token(Token = "0x400FF20")]
	[FieldOffset(Offset = "0x44")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x601094A")]
	[Address(RVA = "0x18CADE8", Offset = "0x18CADE8", VA = "0x18CADE8")]
	public UILuckyWheelPreviewRewardPoolItemController()
	{
	}

	[Token(Token = "0x601094B")]
	[Address(RVA = "0x18CADF0", Offset = "0x18CADF0", VA = "0x18CADF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601094C")]
	[Address(RVA = "0x18CAE98", Offset = "0x18CAE98", VA = "0x18CAE98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601094D")]
	[Address(RVA = "0x18CB2EC", Offset = "0x18CB2EC", VA = "0x18CB2EC")]
	public void SetViewData(BaseItemInfo data)
	{
	}

	[Token(Token = "0x601094E")]
	[Address(RVA = "0x18CB124", Offset = "0x18CB124", VA = "0x18CB124")]
	public void SetHotFlag(bool flag)
	{
	}

	[Token(Token = "0x601094F")]
	[Address(RVA = "0x18CB1BC", Offset = "0x18CB1BC", VA = "0x18CB1BC")]
	public void SetOwnedFlag(bool flag)
	{
	}

	[Token(Token = "0x6010950")]
	[Address(RVA = "0x18CB254", Offset = "0x18CB254", VA = "0x18CB254")]
	public void SetBuyedFlag(bool flag)
	{
	}

	[Token(Token = "0x6010951")]
	[Address(RVA = "0x18CB4B4", Offset = "0x18CB4B4", VA = "0x18CB4B4")]
	private void ShowFullScreenPreview()
	{
	}

	[Token(Token = "0x6010952")]
	[Address(RVA = "0x18CB3FC", Offset = "0x18CB3FC", VA = "0x18CB3FC")]
	private void SetStandItemMiniData(BaseItemInfo data, bool hasTween = true)
	{
	}

	[Token(Token = "0x6010953")]
	[Address(RVA = "0x18CB7DC", Offset = "0x18CB7DC", VA = "0x18CB7DC")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x6010954")]
	[Address(RVA = "0x18CBEFC", Offset = "0x18CBEFC", VA = "0x18CBEFC")]
	public UIDragScrollView GetItemDragView()
	{
		return null;
	}

	[Token(Token = "0x6010955")]
	[Address(RVA = "0x18CBF6C", Offset = "0x18CBF6C", VA = "0x18CBF6C")]
	public void UpdateQuantityLabel(string newCount)
	{
	}

	[Token(Token = "0x6010956")]
	[Address(RVA = "0x18CC018", Offset = "0x18CC018", VA = "0x18CC018")]
	public void SetFlowLightEnable(bool b)
	{
	}

	[Token(Token = "0x6010957")]
	[Address(RVA = "0x18CB850", Offset = "0x18CB850", VA = "0x18CB850")]
	public void RefreshBaseItemView(BaseItemInfo info)
	{
	}

	[Token(Token = "0x6010958")]
	[Address(RVA = "0x18CC0B0", Offset = "0x18CC0B0", VA = "0x18CC0B0")]
	public void SetCustomBtnClickEvent(Callback action)
	{
	}

	[Token(Token = "0x6010959")]
	[Address(RVA = "0x18CC1EC", Offset = "0x18CC1EC", VA = "0x18CC1EC")]
	public void EnableItemBtn()
	{
	}

	[Token(Token = "0x601095A")]
	[Address(RVA = "0x18CC27C", Offset = "0x18CC27C", VA = "0x18CC27C")]
	public void DisableItemBtn()
	{
	}

	[Token(Token = "0x601095B")]
	[Address(RVA = "0x18CB694", Offset = "0x18CB694", VA = "0x18CB694")]
	private void ShowItemPreview()
	{
	}

	[Token(Token = "0x601095C")]
	[Address(RVA = "0x18CC30C", Offset = "0x18CC30C", VA = "0x18CC30C")]
	public void SetQuantityIgnoreOne(bool ignore)
	{
	}

	[Token(Token = "0x601095D")]
	[Address(RVA = "0x18CC398", Offset = "0x18CC398", VA = "0x18CC398", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x601095E")]
	[Address(RVA = "0x18CB8F8", Offset = "0x18CB8F8", VA = "0x18CB8F8")]
	private void SetQualityBg()
	{
	}

	[Token(Token = "0x601095F")]
	[Address(RVA = "0x18CC560", Offset = "0x18CC560", VA = "0x18CC560")]
	public void SetDisountLabel(UIModelLuckyWheel.DiscountType discountType, uint discount)
	{
	}

	[Token(Token = "0x6010960")]
	[Address(RVA = "0x18CC82C", Offset = "0x18CC82C", VA = "0x18CC82C")]
	public void PlayAniamtion()
	{
	}

	[Token(Token = "0x6010961")]
	[Address(RVA = "0x18CC964", Offset = "0x18CC964", VA = "0x18CC964")]
	public void SkipAnimation()
	{
	}

	[Token(Token = "0x6010962")]
	[Address(RVA = "0x18CBBE0", Offset = "0x18CBBE0", VA = "0x18CBBE0")]
	private void SetIPTag()
	{
	}

	[Token(Token = "0x6010963")]
	[Address(RVA = "0x18CCA58", Offset = "0x18CCA58", VA = "0x18CCA58")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
