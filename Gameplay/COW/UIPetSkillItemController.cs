using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A5D")]
public class UIPetSkillItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x401044F")]
	[FieldOffset(Offset = "0x28")]
	private UIpetSkillItemView m_View;

	[Token(Token = "0x4010450")]
	[FieldOffset(Offset = "0x2C")]
	private PetSkillConfigInfo skill_info;

	[Token(Token = "0x4010451")]
	[FieldOffset(Offset = "0x30")]
	private CSSharedItemData inventoryItem;

	[Token(Token = "0x4010452")]
	private const string PET_SELECT_SKILL_TAG = "PET_SKILL_SELECT_TAG";

	[Token(Token = "0x4010453")]
	[FieldOffset(Offset = "0x34")]
	private int m_MinLevel;

	[Token(Token = "0x4010454")]
	[FieldOffset(Offset = "0x38")]
	private int m_CurLevel;

	[Token(Token = "0x4010455")]
	[FieldOffset(Offset = "0x3C")]
	private int m_MaxLevel;

	[Token(Token = "0x6011398")]
	[Address(RVA = "0x2C4B324", Offset = "0x2C4B324", VA = "0x2C4B324")]
	public UIPetSkillItemController()
	{
	}

	[Token(Token = "0x6011399")]
	[Address(RVA = "0x2C4B3A8", Offset = "0x2C4B3A8", VA = "0x2C4B3A8", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601139A")]
	[Address(RVA = "0x2C4B404", Offset = "0x2C4B404", VA = "0x2C4B404")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601139B")]
	[Address(RVA = "0x2C4B4AC", Offset = "0x2C4B4AC", VA = "0x2C4B4AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601139C")]
	[Address(RVA = "0x2C4B864", Offset = "0x2C4B864", VA = "0x2C4B864", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601139D")]
	[Address(RVA = "0x2C4B994", Offset = "0x2C4B994", VA = "0x2C4B994", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601139E")]
	[Address(RVA = "0x2C4BB84", Offset = "0x2C4BB84", VA = "0x2C4BB84")]
	private void ShowSelectedSkillList()
	{
	}

	[Token(Token = "0x601139F")]
	[Address(RVA = "0x2C4C204", Offset = "0x2C4C204", VA = "0x2C4C204")]
	private void GotoPetSource()
	{
	}

	[Token(Token = "0x60113A0")]
	[Address(RVA = "0x2C4BE90", Offset = "0x2C4BE90", VA = "0x2C4BE90")]
	private void FinishSkillGuide()
	{
	}

	[Token(Token = "0x60113A1")]
	[Address(RVA = "0x2C4C554", Offset = "0x2C4C554", VA = "0x2C4C554")]
	private void SelectSkill()
	{
	}

	[Token(Token = "0x60113A2")]
	[Address(RVA = "0x2C4A930", Offset = "0x2C4A930", VA = "0x2C4A930")]
	public void RefreshViewData(PetSkillConfigInfo skillInfo)
	{
	}

	[Token(Token = "0x60113A3")]
	[Address(RVA = "0x2C4CA44", Offset = "0x2C4CA44", VA = "0x2C4CA44")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x60113A4")]
	[Address(RVA = "0x2C4DD00", Offset = "0x2C4DD00", VA = "0x2C4DD00", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60113A5")]
	[Address(RVA = "0x2C4C6C4", Offset = "0x2C4C6C4", VA = "0x2C4C6C4")]
	private void CheckItemTipsState()
	{
	}

	[Token(Token = "0x60113A6")]
	[Address(RVA = "0x2C4ACDC", Offset = "0x2C4ACDC", VA = "0x2C4ACDC")]
	public void ShowItemNoTips(bool isUnlock)
	{
	}

	[Token(Token = "0x60113A7")]
	[Address(RVA = "0x2C4DD94", Offset = "0x2C4DD94", VA = "0x2C4DD94")]
	private void OnLeftBtnClick()
	{
	}

	[Token(Token = "0x60113A8")]
	[Address(RVA = "0x2C4DE14", Offset = "0x2C4DE14", VA = "0x2C4DE14")]
	private void OnRightBtnClick()
	{
	}

	[Token(Token = "0x60113A9")]
	[Address(RVA = "0x2C4D454", Offset = "0x2C4D454", VA = "0x2C4D454")]
	private void RefreshSkillLevel()
	{
	}

	[Token(Token = "0x60113AA")]
	[Address(RVA = "0x2C4DE94", Offset = "0x2C4DE94", VA = "0x2C4DE94")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60113AB")]
	[Address(RVA = "0x2C4DE9C", Offset = "0x2C4DE9C", VA = "0x2C4DE9C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60113AC")]
	[Address(RVA = "0x2C4DEA4", Offset = "0x2C4DEA4", VA = "0x2C4DEA4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
