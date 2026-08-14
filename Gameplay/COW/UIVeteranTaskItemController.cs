using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BF6")]
public class UIVeteranTaskItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x4010C8E")]
	[FieldOffset(Offset = "0x38")]
	private ClientVeteranTaskDesc m_Desc;

	[Token(Token = "0x4010C8F")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelVeteranSignin m_VeteranModel;

	[Token(Token = "0x4010C90")]
	[FieldOffset(Offset = "0x40")]
	private UIVeteranTaskItemView m_View;

	[Token(Token = "0x4010C91")]
	[FieldOffset(Offset = "0x44")]
	private Queue<UIStandardItemMiniController> m_Pool;

	[Token(Token = "0x4010C92")]
	[FieldOffset(Offset = "0x48")]
	private List<UIStandardItemMiniController> m_Items;

	[Token(Token = "0x4010C93")]
	[FieldOffset(Offset = "0x4C")]
	private string PROGRESS_FORMAT;

	[Token(Token = "0x60123A9")]
	[Address(RVA = "0x2CC89C4", Offset = "0x2CC89C4", VA = "0x2CC89C4")]
	public UIVeteranTaskItemController()
	{
	}

	[Token(Token = "0x60123AA")]
	[Address(RVA = "0x2CC8A98", Offset = "0x2CC8A98", VA = "0x2CC8A98")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60123AB")]
	[Address(RVA = "0x2CC8B3C", Offset = "0x2CC8B3C", VA = "0x2CC8B3C")]
	private UIStandardItemMiniController Get()
	{
		return null;
	}

	[Token(Token = "0x60123AC")]
	[Address(RVA = "0x2CC8D94", Offset = "0x2CC8D94", VA = "0x2CC8D94")]
	private void Push(UIStandardItemMiniController item)
	{
	}

	[Token(Token = "0x60123AD")]
	[Address(RVA = "0x2CC8EE4", Offset = "0x2CC8EE4", VA = "0x2CC8EE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60123AE")]
	[Address(RVA = "0x2CC90D0", Offset = "0x2CC90D0", VA = "0x2CC90D0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60123AF")]
	[Address(RVA = "0x2CC9200", Offset = "0x2CC9200", VA = "0x2CC9200", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60123B0")]
	[Address(RVA = "0x2CC9E10", Offset = "0x2CC9E10", VA = "0x2CC9E10")]
	private void CreateAwards(List<AwardDesc> awards)
	{
	}

	[Token(Token = "0x60123B1")]
	[Address(RVA = "0x2CCA120", Offset = "0x2CCA120", VA = "0x2CCA120", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60123B2")]
	[Address(RVA = "0x2CCA1B4", Offset = "0x2CCA1B4", VA = "0x2CCA1B4", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60123B3")]
	[Address(RVA = "0x2CC974C", Offset = "0x2CC974C", VA = "0x2CC974C")]
	private void SetOperateButtonUI()
	{
	}

	[Token(Token = "0x60123B4")]
	[Address(RVA = "0x2CCA280", Offset = "0x2CCA280", VA = "0x2CCA280")]
	private void OnOperate()
	{
	}

	[Token(Token = "0x60123B5")]
	[Address(RVA = "0x2CCA3BC", Offset = "0x2CCA3BC", VA = "0x2CCA3BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60123B6")]
	[Address(RVA = "0x2CCA3C4", Offset = "0x2CCA3C4", VA = "0x2CCA3C4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
