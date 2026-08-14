using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A5E")]
public class UIPetSkillSelcetItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x4010456")]
	[FieldOffset(Offset = "0x38")]
	private UIpetSelectSkillItemView m_View;

	[Token(Token = "0x4010457")]
	[FieldOffset(Offset = "0x3C")]
	private PetSkillConfigInfo skill_info;

	[Token(Token = "0x4010458")]
	[FieldOffset(Offset = "0x40")]
	private CSSharedItemData inventoryItem;

	[Token(Token = "0x60113AD")]
	[Address(RVA = "0x2C4E1C0", Offset = "0x2C4E1C0", VA = "0x2C4E1C0")]
	public UIPetSkillSelcetItemController()
	{
	}

	[Token(Token = "0x60113AE")]
	[Address(RVA = "0x2C4E1C8", Offset = "0x2C4E1C8", VA = "0x2C4E1C8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60113AF")]
	[Address(RVA = "0x2C4E270", Offset = "0x2C4E270", VA = "0x2C4E270", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60113B0")]
	[Address(RVA = "0x2C4E45C", Offset = "0x2C4E45C", VA = "0x2C4E45C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60113B1")]
	[Address(RVA = "0x2C4E58C", Offset = "0x2C4E58C", VA = "0x2C4E58C", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60113B2")]
	[Address(RVA = "0x2C4E600", Offset = "0x2C4E600", VA = "0x2C4E600")]
	private void SelectCurrentSkill()
	{
	}

	[Token(Token = "0x60113B3")]
	[Address(RVA = "0x2C4E868", Offset = "0x2C4E868", VA = "0x2C4E868")]
	private void SelectSkill()
	{
	}

	[Token(Token = "0x60113B4")]
	[Address(RVA = "0x2C4E9D8", Offset = "0x2C4E9D8", VA = "0x2C4E9D8", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60113B5")]
	[Address(RVA = "0x2C4EBB0", Offset = "0x2C4EBB0", VA = "0x2C4EBB0")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x60113B6")]
	[Address(RVA = "0x2C4F190", Offset = "0x2C4F190", VA = "0x2C4F190", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60113B7")]
	[Address(RVA = "0x2C4F224", Offset = "0x2C4F224", VA = "0x2C4F224")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60113B8")]
	[Address(RVA = "0x2C4F22C", Offset = "0x2C4F22C", VA = "0x2C4F22C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
