using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200299B")]
internal class UIMapModeItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x401000B")]
	[FieldOffset(Offset = "0x28")]
	private UIMapModeItemView m_View;

	[Token(Token = "0x401000C")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x401000D")]
	[FieldOffset(Offset = "0x30")]
	private MapModeData m_MapModeData;

	[Token(Token = "0x401000E")]
	[FieldOffset(Offset = "0x34")]
	private UIRankGuideController m_GuideCtrl;

	[Token(Token = "0x401000F")]
	[FieldOffset(Offset = "0x38")]
	private UIModelLadderMatch m_ladderModel;

	[Token(Token = "0x4010010")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x6010B5E")]
	[Address(RVA = "0x2801EE4", Offset = "0x2801EE4", VA = "0x2801EE4")]
	public UIMapModeItemController()
	{
	}

	[Token(Token = "0x6010B5F")]
	[Address(RVA = "0x2801F68", Offset = "0x2801F68", VA = "0x2801F68")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B60")]
	[Address(RVA = "0x2802010", Offset = "0x2802010", VA = "0x2802010", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B61")]
	[Address(RVA = "0x2802424", Offset = "0x2802424", VA = "0x2802424", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010B62")]
	[Address(RVA = "0x28026B8", Offset = "0x28026B8", VA = "0x28026B8")]
	public void SetUIData(MapModeData data)
	{
	}

	[Token(Token = "0x6010B63")]
	[Address(RVA = "0x2803FFC", Offset = "0x2803FFC", VA = "0x2803FFC")]
	private void RefreshOpeningUI()
	{
	}

	[Token(Token = "0x6010B64")]
	[Address(RVA = "0x28048D8", Offset = "0x28048D8", VA = "0x28048D8")]
	private void OnMapModeClick()
	{
	}

	[Token(Token = "0x6010B65")]
	[Address(RVA = "0x2804B8C", Offset = "0x2804B8C", VA = "0x2804B8C")]
	private void HighLightDefault(bool trigger = true)
	{
	}

	[Token(Token = "0x6010B66")]
	[Address(RVA = "0x2804E1C", Offset = "0x2804E1C", VA = "0x2804E1C")]
	private void OnGroupQuit(object[] data)
	{
	}

	[Token(Token = "0x6010B67")]
	[Address(RVA = "0x2804A50", Offset = "0x2804A50", VA = "0x2804A50")]
	private void ClearGuide()
	{
	}

	[Token(Token = "0x6010B68")]
	[Address(RVA = "0x2804E90", Offset = "0x2804E90", VA = "0x2804E90")]
	private void OnVisible(object[] data)
	{
	}

	[Token(Token = "0x6010B69")]
	[Address(RVA = "0x2805090", Offset = "0x2805090", VA = "0x2805090")]
	private void OnMapRevert(object[] data)
	{
	}

	[Token(Token = "0x6010B6A")]
	[Address(RVA = "0x280531C", Offset = "0x280531C", VA = "0x280531C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010B6B")]
	[Address(RVA = "0x2805400", Offset = "0x2805400", VA = "0x2805400", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010B6C")]
	[Address(RVA = "0x2805494", Offset = "0x2805494", VA = "0x2805494")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010B6D")]
	[Address(RVA = "0x280549C", Offset = "0x280549C", VA = "0x280549C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
