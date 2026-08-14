using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026A1")]
internal class UIGameModeCasualInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400EE46")]
	[FieldOffset(Offset = "0x28")]
	public UIGameModeBaseItemController m_ParentController;

	[Token(Token = "0x400EE47")]
	[FieldOffset(Offset = "0x2C")]
	private UIGameModeCasualInfoView m_View;

	[Token(Token = "0x400EE48")]
	[FieldOffset(Offset = "0x30")]
	private List<MapModeData> m_Data;

	[Token(Token = "0x400EE49")]
	[FieldOffset(Offset = "0x34")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400EE4A")]
	[FieldOffset(Offset = "0x38")]
	private UIModelLadderMatch m_ladderModel;

	[Token(Token = "0x400EE4B")]
	[FieldOffset(Offset = "0x3C")]
	private MapModeData m_SelectedMapModeData;

	[Token(Token = "0x400EE4C")]
	[FieldOffset(Offset = "0x40")]
	private int m_CurrentSelectedIndex;

	[Token(Token = "0x400EE4D")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<MapModeData> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x17001195")]
	public int CurrentSelectedIndex
	{
		[Token(Token = "0x600E864")]
		[Address(RVA = "0x246A50C", Offset = "0x246A50C", VA = "0x246A50C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600E863")]
	[Address(RVA = "0x246A488", Offset = "0x246A488", VA = "0x246A488")]
	public UIGameModeCasualInfoController()
	{
	}

	[Token(Token = "0x600E865")]
	[Address(RVA = "0x246A564", Offset = "0x246A564", VA = "0x246A564", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E866")]
	[Address(RVA = "0x246A5C0", Offset = "0x246A5C0", VA = "0x246A5C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E867")]
	[Address(RVA = "0x246A668", Offset = "0x246A668", VA = "0x246A668", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E868")]
	[Address(RVA = "0x246A9C8", Offset = "0x246A9C8", VA = "0x246A9C8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E869")]
	[Address(RVA = "0x24621EC", Offset = "0x24621EC", VA = "0x24621EC")]
	public void SetParentController(UIGameModeBaseItemController controller)
	{
	}

	[Token(Token = "0x600E86A")]
	[Address(RVA = "0x246AA2C", Offset = "0x246AA2C", VA = "0x246AA2C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E86B")]
	[Address(RVA = "0x246D0C8", Offset = "0x246D0C8", VA = "0x246D0C8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E86C")]
	[Address(RVA = "0x246D180", Offset = "0x246D180", VA = "0x246D180", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E86D")]
	[Address(RVA = "0x246AB60", Offset = "0x246AB60", VA = "0x246AB60")]
	private void RefreshCurrentSelectedIndex()
	{
	}

	[Token(Token = "0x600E86E")]
	[Address(RVA = "0x246224C", Offset = "0x246224C", VA = "0x246224C")]
	public void SetUIData(List<MapModeData> dataList)
	{
	}

	[Token(Token = "0x600E86F")]
	[Address(RVA = "0x246D7F0", Offset = "0x246D7F0", VA = "0x246D7F0")]
	private void OnHelpBtnCLick()
	{
	}

	[Token(Token = "0x600E870")]
	[Address(RVA = "0x246DB98", Offset = "0x246DB98", VA = "0x246DB98")]
	private void ShowHelpBtn(MapModeData data)
	{
	}

	[Token(Token = "0x600E871")]
	[Address(RVA = "0x246AEC8", Offset = "0x246AEC8", VA = "0x246AEC8")]
	private void SetSelectedMapUIData(MapModeData data)
	{
	}

	[Token(Token = "0x600E872")]
	[Address(RVA = "0x246DC84", Offset = "0x246DC84", VA = "0x246DC84")]
	private bool ShouldShowSwitchButton()
	{
		return default(bool);
	}

	[Token(Token = "0x600E873")]
	[Address(RVA = "0x246CA1C", Offset = "0x246CA1C", VA = "0x246CA1C")]
	private void RefreshOpeningUI()
	{
	}

	[Token(Token = "0x600E874")]
	[Address(RVA = "0x246DEF4", Offset = "0x246DEF4", VA = "0x246DEF4")]
	private void OnSwitchMapModeClick()
	{
	}

	[Token(Token = "0x600E875")]
	[Address(RVA = "0x246E2EC", Offset = "0x246E2EC", VA = "0x246E2EC")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E876")]
	[Address(RVA = "0x246E2F4", Offset = "0x246E2F4", VA = "0x246E2F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E877")]
	[Address(RVA = "0x246E2FC", Offset = "0x246E2FC", VA = "0x246E2FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E878")]
	[Address(RVA = "0x246E304", Offset = "0x246E304", VA = "0x246E304")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
