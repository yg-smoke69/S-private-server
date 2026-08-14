using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002587")]
public class UICommonRewardItemController : UIBaseController
{
	[Token(Token = "0x2002588")]
	private enum EquipmentState
	{
		[Token(Token = "0x400E835")]
		STATE_NONE,
		[Token(Token = "0x400E836")]
		STATE_CHECK,
		[Token(Token = "0x400E837")]
		STATE_UNCHECK,
		[Token(Token = "0x400E838")]
		STATE_EQUIPPED
	}

	[Token(Token = "0x2002589")]
	private sealed class _003CIsCanEquip_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E839")]
		[FieldOffset(Offset = "0x8")]
		internal PetSkinData skinData;

		[Token(Token = "0x600DB88")]
		[Address(RVA = "0x2CE729C", Offset = "0x2CE729C", VA = "0x2CE729C")]
		public _003CIsCanEquip_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DB89")]
		[Address(RVA = "0x2CE8D84", Offset = "0x2CE8D84", VA = "0x2CE8D84")]
		internal bool _003C_003Em__0(PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E82C")]
	[FieldOffset(Offset = "0x28")]
	private UICommonRewardItemView m_View;

	[Token(Token = "0x400E82D")]
	[FieldOffset(Offset = "0x2C")]
	private UIStandardItemMAXBController m_childController;

	[Token(Token = "0x400E82E")]
	[FieldOffset(Offset = "0x30")]
	public CommonRewardItemInfo m_Info;

	[Token(Token = "0x400E82F")]
	[FieldOffset(Offset = "0x34")]
	public OptionalBundleShowData m_OptionalBundleInfo;

	[Token(Token = "0x400E830")]
	[FieldOffset(Offset = "0x38")]
	private bool m_CanEquip;

	[Token(Token = "0x400E831")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_RealItemId;

	[Token(Token = "0x400E832")]
	[FieldOffset(Offset = "0x40")]
	private EquipmentState m_EquipmentState;

	[Token(Token = "0x400E833")]
	[FieldOffset(Offset = "0x44")]
	private bool IsOwnedLabelEnable;

	[Token(Token = "0x17001147")]
	public bool CanEquip
	{
		[Token(Token = "0x600DB68")]
		[Address(RVA = "0x2CE56C0", Offset = "0x2CE56C0", VA = "0x2CE56C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001148")]
	public uint RealItemID
	{
		[Token(Token = "0x600DB69")]
		[Address(RVA = "0x2CE5718", Offset = "0x2CE5718", VA = "0x2CE5718")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x600DB67")]
	[Address(RVA = "0x2CE5634", Offset = "0x2CE5634", VA = "0x2CE5634")]
	public UICommonRewardItemController()
	{
	}

	[Token(Token = "0x600DB6A")]
	[Address(RVA = "0x2CE5770", Offset = "0x2CE5770", VA = "0x2CE5770")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DB6B")]
	[Address(RVA = "0x2CE5814", Offset = "0x2CE5814", VA = "0x2CE5814")]
	public UICommonRewardItemView GetRewardItemView()
	{
		return null;
	}

	[Token(Token = "0x600DB6C")]
	[Address(RVA = "0x2CE586C", Offset = "0x2CE586C", VA = "0x2CE586C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DB6D")]
	[Address(RVA = "0x2CE5CB8", Offset = "0x2CE5CB8", VA = "0x2CE5CB8")]
	public UIWidget GetParticleWidget()
	{
		return null;
	}

	[Token(Token = "0x600DB6E")]
	[Address(RVA = "0x2CE5DE8", Offset = "0x2CE5DE8", VA = "0x2CE5DE8")]
	public Transform GetChildStandardItemTrans()
	{
		return null;
	}

	[Token(Token = "0x600DB6F")]
	public void SetViewInfo<T>(CommonRewardItemInfo info) where T : UIStandardItemMAXBController
	{
	}

	[Token(Token = "0x600DB70")]
	[Address(RVA = "0x2CE5EE0", Offset = "0x2CE5EE0", VA = "0x2CE5EE0")]
	public void SetViewInfo(CommonRewardItemInfo info, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	[Token(Token = "0x600DB71")]
	public void SetOptionalBundleInfo<T>(CommonRewardItemInfo info, OptionalBundleShowData optionalBundleInfo) where T : UIStandardItemMAXBController
	{
	}

	[Token(Token = "0x600DB72")]
	[Address(RVA = "0x2CE66A4", Offset = "0x2CE66A4", VA = "0x2CE66A4")]
	public void ShowView(UICommonRewardWndController.WndStyleEnum style)
	{
	}

	[Token(Token = "0x600DB73")]
	[Address(RVA = "0x2CE69C8", Offset = "0x2CE69C8", VA = "0x2CE69C8")]
	public void SetViewScale(float scale)
	{
	}

	[Token(Token = "0x600DB74")]
	[Address(RVA = "0x2CE6B9C", Offset = "0x2CE6B9C", VA = "0x2CE6B9C")]
	public void SetVoucherAnimEnable(bool b)
	{
	}

	[Token(Token = "0x600DB75")]
	[Address(RVA = "0x2CE6C34", Offset = "0x2CE6C34", VA = "0x2CE6C34")]
	public void PlayAudio(bool useNewAudio = false)
	{
	}

	[Token(Token = "0x600DB76")]
	[Address(RVA = "0x2CE5B50", Offset = "0x2CE5B50", VA = "0x2CE5B50")]
	public void SetToggleVisible(bool v)
	{
	}

	[Token(Token = "0x600DB77")]
	[Address(RVA = "0x2CE6E5C", Offset = "0x2CE6E5C", VA = "0x2CE6E5C")]
	public void SetToggleCheckState()
	{
	}

	[Token(Token = "0x600DB78")]
	[Address(RVA = "0x2CE7148", Offset = "0x2CE7148", VA = "0x2CE7148")]
	public void SetToggleUnCheckState()
	{
	}

	[Token(Token = "0x600DB79")]
	[Address(RVA = "0x2CE71BC", Offset = "0x2CE71BC", VA = "0x2CE71BC")]
	public void SetToggleEquippedState()
	{
	}

	[Token(Token = "0x600DB7A")]
	[Address(RVA = "0x2CE7230", Offset = "0x2CE7230", VA = "0x2CE7230")]
	public bool IsAlreadyEquipped()
	{
		return default(bool);
	}

	[Token(Token = "0x600DB7B")]
	[Address(RVA = "0x2CE60DC", Offset = "0x2CE60DC", VA = "0x2CE60DC")]
	private void SetRealItemID()
	{
	}

	[Token(Token = "0x600DB7C")]
	[Address(RVA = "0x2CE6270", Offset = "0x2CE6270", VA = "0x2CE6270")]
	private bool IsCanEquip()
	{
		return default(bool);
	}

	[Token(Token = "0x600DB7D")]
	[Address(RVA = "0x2CE6ED0", Offset = "0x2CE6ED0", VA = "0x2CE6ED0")]
	private void SetToggleValue(bool v)
	{
	}

	[Token(Token = "0x600DB7E")]
	[Address(RVA = "0x2CE72A4", Offset = "0x2CE72A4", VA = "0x2CE72A4")]
	private void OnToggleSelected()
	{
	}

	[Token(Token = "0x600DB7F")]
	[Address(RVA = "0x2CE87E8", Offset = "0x2CE87E8", VA = "0x2CE87E8")]
	private void OnOptionalToggleSelected()
	{
	}

	[Token(Token = "0x600DB80")]
	[Address(RVA = "0x2CE8A88", Offset = "0x2CE8A88", VA = "0x2CE8A88")]
	public void RefreshOptionalToggle(uint order)
	{
	}

	[Token(Token = "0x600DB81")]
	[Address(RVA = "0x2CE6F68", Offset = "0x2CE6F68", VA = "0x2CE6F68")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600DB82")]
	[Address(RVA = "0x2CE8B6C", Offset = "0x2CE8B6C", VA = "0x2CE8B6C")]
	public void SetUseNewGachaAnimatoin(bool useNewGachaAnimatoin, bool showTween)
	{
	}

	[Token(Token = "0x600DB83")]
	[Address(RVA = "0x2CE8CA4", Offset = "0x2CE8CA4", VA = "0x2CE8CA4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600DB84")]
	[Address(RVA = "0x2CE8D08", Offset = "0x2CE8D08", VA = "0x2CE8D08", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DB85")]
	[Address(RVA = "0x2CE8D6C", Offset = "0x2CE8D6C", VA = "0x2CE8D6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DB86")]
	[Address(RVA = "0x2CE8D74", Offset = "0x2CE8D74", VA = "0x2CE8D74")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600DB87")]
	[Address(RVA = "0x2CE8D7C", Offset = "0x2CE8D7C", VA = "0x2CE8D7C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
