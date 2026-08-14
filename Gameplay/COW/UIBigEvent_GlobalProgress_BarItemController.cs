using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E8F")]
public class UIBigEvent_GlobalProgress_BarItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400C026")]
	[FieldOffset(Offset = "0x28")]
	private UIBigEvent_GlobalProgress_BarItemView m_View;

	[Token(Token = "0x400C027")]
	[FieldOffset(Offset = "0x2C")]
	public CustomEventProcessSettingDesc Data;

	[Token(Token = "0x400C028")]
	[FieldOffset(Offset = "0x30")]
	private UIModelBigEvent_GlobalProgress m_UIModelBigEvent_GlobalProgress;

	[Token(Token = "0x400C029")]
	[FieldOffset(Offset = "0x34")]
	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	[Token(Token = "0x400C02A")]
	[FieldOffset(Offset = "0x38")]
	private UIStandardItemMiniController m_StandardItemCtrl;

	[Token(Token = "0x600932A")]
	[Address(RVA = "0x301DD20", Offset = "0x301DD20", VA = "0x301DD20")]
	public UIBigEvent_GlobalProgress_BarItemController()
	{
	}

	[Token(Token = "0x600932B")]
	[Address(RVA = "0x301DDA4", Offset = "0x301DDA4", VA = "0x301DDA4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600932C")]
	[Address(RVA = "0x301DE4C", Offset = "0x301DE4C", VA = "0x301DE4C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600932D")]
	[Address(RVA = "0x301DFE0", Offset = "0x301DFE0", VA = "0x301DFE0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600932E")]
	[Address(RVA = "0x301E068", Offset = "0x301E068", VA = "0x301E068", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600932F")]
	[Address(RVA = "0x301E0DC", Offset = "0x301E0DC", VA = "0x301E0DC", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009330")]
	[Address(RVA = "0x301C9CC", Offset = "0x301C9CC", VA = "0x301C9CC")]
	public void SetData(CustomEventProcessSettingDesc data)
	{
	}

	[Token(Token = "0x6009331")]
	[Address(RVA = "0x301E140", Offset = "0x301E140", VA = "0x301E140")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6009332")]
	[Address(RVA = "0x301E994", Offset = "0x301E994", VA = "0x301E994")]
	private void RefreshTextureRewardBg()
	{
	}

	[Token(Token = "0x6009333")]
	[Address(RVA = "0x301EB9C", Offset = "0x301EB9C", VA = "0x301EB9C")]
	private void ShowRewardItemInfo()
	{
	}

	[Token(Token = "0x6009334")]
	[Address(RVA = "0x301ED94", Offset = "0x301ED94", VA = "0x301ED94")]
	private void OnClickBtnAward()
	{
	}

	[Token(Token = "0x6009335")]
	[Address(RVA = "0x301E8D8", Offset = "0x301E8D8", VA = "0x301E8D8")]
	private EActivity.State GetRewardState()
	{
		return default(EActivity.State);
	}

	[Token(Token = "0x6009336")]
	[Address(RVA = "0x301EE60", Offset = "0x301EE60", VA = "0x301EE60")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009337")]
	[Address(RVA = "0x301EE68", Offset = "0x301EE68", VA = "0x301EE68")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
