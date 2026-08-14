using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024EF")]
public class UIAwardItemController : UIBaseController
{
	[Token(Token = "0x20024F0")]
	private enum EquipmentState
	{
		[Token(Token = "0x400E501")]
		EQUIPMENTSTATE_NONE,
		[Token(Token = "0x400E502")]
		EQUIPMENTSTATE_CHECK,
		[Token(Token = "0x400E503")]
		EQUIPMENTSTATE_UNCHECK,
		[Token(Token = "0x400E504")]
		EQUIPMENTSTATE_EQUIPPED
	}

	[Token(Token = "0x400E4FC")]
	[FieldOffset(Offset = "0x28")]
	private UIAwardItemView m_View;

	[Token(Token = "0x400E4FD")]
	[FieldOffset(Offset = "0x2C")]
	private BaseItemInfo m_Info;

	[Token(Token = "0x400E4FE")]
	[FieldOffset(Offset = "0x30")]
	private int m_AwardKey;

	[Token(Token = "0x400E4FF")]
	[FieldOffset(Offset = "0x34")]
	private EquipmentState m_EquipmentState;

	[Token(Token = "0x17001140")]
	public BaseItemInfo ItemInfo
	{
		[Token(Token = "0x600D4FE")]
		[Address(RVA = "0x1401DAC", Offset = "0x1401DAC", VA = "0x1401DAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600D4FF")]
		[Address(RVA = "0x1401E04", Offset = "0x1401E04", VA = "0x1401E04")]
		set
		{
		}
	}

	[Token(Token = "0x17001141")]
	public int AwardKey
	{
		[Token(Token = "0x600D500")]
		[Address(RVA = "0x1401E64", Offset = "0x1401E64", VA = "0x1401E64")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600D4FD")]
	[Address(RVA = "0x1401D20", Offset = "0x1401D20", VA = "0x1401D20")]
	public UIAwardItemController()
	{
	}

	[Token(Token = "0x600D501")]
	[Address(RVA = "0x1401EBC", Offset = "0x1401EBC", VA = "0x1401EBC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D502")]
	[Address(RVA = "0x1401F60", Offset = "0x1401F60", VA = "0x1401F60", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D503")]
	[Address(RVA = "0x14020BC", Offset = "0x14020BC", VA = "0x14020BC")]
	public void SetViewData(BaseItemInfo info)
	{
	}

	[Token(Token = "0x600D504")]
	[Address(RVA = "0x1402374", Offset = "0x1402374", VA = "0x1402374")]
	public void SetToggleVisible(bool v)
	{
	}

	[Token(Token = "0x600D505")]
	[Address(RVA = "0x14024DC", Offset = "0x14024DC", VA = "0x14024DC")]
	public void SetAwardCheckState()
	{
	}

	[Token(Token = "0x600D506")]
	[Address(RVA = "0x14027C8", Offset = "0x14027C8", VA = "0x14027C8")]
	public void SetAwardUnCheckState()
	{
	}

	[Token(Token = "0x600D507")]
	[Address(RVA = "0x140283C", Offset = "0x140283C", VA = "0x140283C")]
	public void SetAwardEquippedState()
	{
	}

	[Token(Token = "0x600D508")]
	[Address(RVA = "0x14028B0", Offset = "0x14028B0", VA = "0x14028B0")]
	public bool IsAlreadyEquipped()
	{
		return default(bool);
	}

	[Token(Token = "0x600D509")]
	[Address(RVA = "0x140291C", Offset = "0x140291C", VA = "0x140291C")]
	public CSSharedItemDataManager.ItemType GetAwardType()
	{
		return default(CSSharedItemDataManager.ItemType);
	}

	[Token(Token = "0x600D50A")]
	[Address(RVA = "0x140298C", Offset = "0x140298C", VA = "0x140298C")]
	public int GetAwardSubType()
	{
		return default(int);
	}

	[Token(Token = "0x600D50B")]
	[Address(RVA = "0x140216C", Offset = "0x140216C", VA = "0x140216C")]
	public static int GenAwardKey(BaseItemInfo info)
	{
		return default(int);
	}

	[Token(Token = "0x600D50C")]
	[Address(RVA = "0x1402550", Offset = "0x1402550", VA = "0x1402550")]
	private void SetToggleValue(bool v)
	{
	}

	[Token(Token = "0x600D50D")]
	[Address(RVA = "0x1402A04", Offset = "0x1402A04", VA = "0x1402A04")]
	private void OnToggleSelected()
	{
	}

	[Token(Token = "0x600D50E")]
	[Address(RVA = "0x14025E8", Offset = "0x14025E8", VA = "0x14025E8")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600D50F")]
	[Address(RVA = "0x1402CF0", Offset = "0x1402CF0", VA = "0x1402CF0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D510")]
	[Address(RVA = "0x1402D54", Offset = "0x1402D54", VA = "0x1402D54", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D511")]
	[Address(RVA = "0x1402DB8", Offset = "0x1402DB8", VA = "0x1402DB8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D512")]
	[Address(RVA = "0x1402DC0", Offset = "0x1402DC0", VA = "0x1402DC0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600D513")]
	[Address(RVA = "0x1402DC8", Offset = "0x1402DC8", VA = "0x1402DC8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
