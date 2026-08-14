using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BD9")]
internal class UIVeteranDailyMissionItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010BF0")]
	[FieldOffset(Offset = "0x28")]
	private ClientVeteranTaskDesc m_Desc;

	[Token(Token = "0x4010BF1")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelVeteranSignin m_VeteranModel;

	[Token(Token = "0x4010BF2")]
	[FieldOffset(Offset = "0x30")]
	private UIVeteranDailyMissionItemView m_View;

	[Token(Token = "0x4010BF3")]
	[FieldOffset(Offset = "0x34")]
	private Queue<UIStandardItemMiniController> m_Pool;

	[Token(Token = "0x4010BF4")]
	[FieldOffset(Offset = "0x38")]
	private List<UIStandardItemMiniController> m_Items;

	[Token(Token = "0x4010BF5")]
	[FieldOffset(Offset = "0x3C")]
	private int m_Index;

	[Token(Token = "0x6012254")]
	[Address(RVA = "0x284DB6C", Offset = "0x284DB6C", VA = "0x284DB6C")]
	public UIVeteranDailyMissionItemController()
	{
	}

	[Token(Token = "0x6012255")]
	[Address(RVA = "0x284DC58", Offset = "0x284DC58", VA = "0x284DC58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012256")]
	[Address(RVA = "0x284DCFC", Offset = "0x284DCFC", VA = "0x284DCFC")]
	private UIStandardItemMiniController Get()
	{
		return null;
	}

	[Token(Token = "0x6012257")]
	[Address(RVA = "0x284DF54", Offset = "0x284DF54", VA = "0x284DF54")]
	private void Push(UIStandardItemMiniController item)
	{
	}

	[Token(Token = "0x6012258")]
	[Address(RVA = "0x284E0A4", Offset = "0x284E0A4", VA = "0x284E0A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012259")]
	[Address(RVA = "0x284E2D4", Offset = "0x284E2D4", VA = "0x284E2D4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601225A")]
	[Address(RVA = "0x284A990", Offset = "0x284A990", VA = "0x284A990")]
	public void SetViewData(ClientVeteranTaskDesc data, int index)
	{
	}

	[Token(Token = "0x601225B")]
	[Address(RVA = "0x284CCA4", Offset = "0x284CCA4", VA = "0x284CCA4")]
	public void PlayAnimatoin()
	{
	}

	[Token(Token = "0x601225C")]
	[Address(RVA = "0x284E7D0", Offset = "0x284E7D0", VA = "0x284E7D0")]
	private void CreateAwards(List<AwardDesc> awards)
	{
	}

	[Token(Token = "0x601225D")]
	[Address(RVA = "0x284EC3C", Offset = "0x284EC3C", VA = "0x284EC3C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601225E")]
	[Address(RVA = "0x284ECD0", Offset = "0x284ECD0", VA = "0x284ECD0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601225F")]
	[Address(RVA = "0x284E404", Offset = "0x284E404", VA = "0x284E404")]
	private void SetOperateButtonUI()
	{
	}

	[Token(Token = "0x6012260")]
	[Address(RVA = "0x284ED9C", Offset = "0x284ED9C", VA = "0x284ED9C")]
	private void OnOperate()
	{
	}

	[Token(Token = "0x6012261")]
	[Address(RVA = "0x284F000", Offset = "0x284F000", VA = "0x284F000")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012262")]
	[Address(RVA = "0x284F008", Offset = "0x284F008", VA = "0x284F008")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
