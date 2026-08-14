using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A59")]
public class UIPetItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x4010443")]
	[FieldOffset(Offset = "0x38")]
	private UIPetCommonItemView m_View;

	[Token(Token = "0x4010444")]
	[FieldOffset(Offset = "0x3C")]
	private PetInfo pet_info;

	[Token(Token = "0x4010445")]
	[FieldOffset(Offset = "0x40")]
	private bool isSelected;

	[Token(Token = "0x6011364")]
	[Address(RVA = "0x2C46DEC", Offset = "0x2C46DEC", VA = "0x2C46DEC")]
	public UIPetItemController()
	{
	}

	[Token(Token = "0x6011365")]
	[Address(RVA = "0x2C46DF4", Offset = "0x2C46DF4", VA = "0x2C46DF4", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011366")]
	[Address(RVA = "0x2C46E50", Offset = "0x2C46E50", VA = "0x2C46E50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011367")]
	[Address(RVA = "0x2C46EF8", Offset = "0x2C46EF8", VA = "0x2C46EF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011368")]
	[Address(RVA = "0x2C471B0", Offset = "0x2C471B0", VA = "0x2C471B0", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6011369")]
	[Address(RVA = "0x2C47B60", Offset = "0x2C47B60", VA = "0x2C47B60", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x601136A")]
	[Address(RVA = "0x2C477F8", Offset = "0x2C477F8", VA = "0x2C477F8")]
	public void SetHighLightBGState(bool show)
	{
	}

	[Token(Token = "0x601136B")]
	[Address(RVA = "0x2C47BD0", Offset = "0x2C47BD0", VA = "0x2C47BD0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x601136C")]
	[Address(RVA = "0x2C47D28", Offset = "0x2C47D28", VA = "0x2C47D28")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x601136D")]
	[Address(RVA = "0x2C478CC", Offset = "0x2C478CC", VA = "0x2C478CC")]
	public void CheckNewTag(object[] param)
	{
	}

	[Token(Token = "0x601136E")]
	[Address(RVA = "0x2C480A4", Offset = "0x2C480A4", VA = "0x2C480A4")]
	public void SetCarryShow(PetInfo info)
	{
	}

	[Token(Token = "0x601136F")]
	[Address(RVA = "0x2C481A8", Offset = "0x2C481A8", VA = "0x2C481A8", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011370")]
	[Address(RVA = "0x2C4823C", Offset = "0x2C4823C", VA = "0x2C4823C", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011371")]
	[Address(RVA = "0x2C484E4", Offset = "0x2C484E4", VA = "0x2C484E4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011372")]
	[Address(RVA = "0x2C486A8", Offset = "0x2C486A8", VA = "0x2C486A8")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011373")]
	[Address(RVA = "0x2C486B0", Offset = "0x2C486B0", VA = "0x2C486B0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011374")]
	[Address(RVA = "0x2C486B8", Offset = "0x2C486B8", VA = "0x2C486B8")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6011375")]
	[Address(RVA = "0x2C486C0", Offset = "0x2C486C0", VA = "0x2C486C0")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6011376")]
	[Address(RVA = "0x2C486C8", Offset = "0x2C486C8", VA = "0x2C486C8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
