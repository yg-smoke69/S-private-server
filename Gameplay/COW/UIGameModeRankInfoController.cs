using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026B0")]
internal class UIGameModeRankInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400EEC0")]
	[FieldOffset(Offset = "0x28")]
	private UIGameModeRankInfoView m_View;

	[Token(Token = "0x400EEC1")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelLadderMatch m_ladderModel;

	[Token(Token = "0x400EEC2")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x600E92D")]
	[Address(RVA = "0x21911DC", Offset = "0x21911DC", VA = "0x21911DC")]
	public UIGameModeRankInfoController()
	{
	}

	[Token(Token = "0x600E92E")]
	[Address(RVA = "0x2191260", Offset = "0x2191260", VA = "0x2191260")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E92F")]
	[Address(RVA = "0x2191308", Offset = "0x2191308", VA = "0x2191308", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E930")]
	[Address(RVA = "0x21915CC", Offset = "0x21915CC", VA = "0x21915CC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E931")]
	[Address(RVA = "0x2191654", Offset = "0x2191654", VA = "0x2191654")]
	public void SetUIData(List<MapModeData> data)
	{
	}

	[Token(Token = "0x600E932")]
	[Address(RVA = "0x2191728", Offset = "0x2191728", VA = "0x2191728")]
	private void SetSelectedMapUIData(MapModeData data)
	{
	}

	[Token(Token = "0x600E933")]
	[Address(RVA = "0x2192688", Offset = "0x2192688", VA = "0x2192688")]
	private void OnRankBtnClick()
	{
	}

	[Token(Token = "0x600E934")]
	[Address(RVA = "0x21926DC", Offset = "0x21926DC", VA = "0x21926DC")]
	private void OnMapChangeButtonClicked()
	{
	}

	[Token(Token = "0x600E935")]
	[Address(RVA = "0x2192878", Offset = "0x2192878", VA = "0x2192878", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E936")]
	[Address(RVA = "0x219290C", Offset = "0x219290C", VA = "0x219290C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E937")]
	[Address(RVA = "0x21921A8", Offset = "0x21921A8", VA = "0x21921A8")]
	private void SetRPData()
	{
	}

	[Token(Token = "0x600E938")]
	[Address(RVA = "0x21929D8", Offset = "0x21929D8", VA = "0x21929D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E939")]
	[Address(RVA = "0x21929E0", Offset = "0x21929E0", VA = "0x21929E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
