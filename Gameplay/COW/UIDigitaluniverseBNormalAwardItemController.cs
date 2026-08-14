using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EE4")]
public class UIDigitaluniverseBNormalAwardItemController : UIBaseController
{
	[Token(Token = "0x400C288")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitaluniverseBAwardItemView m_View;

	[Token(Token = "0x400C289")]
	[FieldOffset(Offset = "0x2C")]
	private DigitaluniverseBMissionRewardDesc m_Data;

	[Token(Token = "0x400C28A")]
	[FieldOffset(Offset = "0x30")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C28B")]
	[FieldOffset(Offset = "0x34")]
	private UIStandardItemMiniController m_ItemCtrl;

	[Token(Token = "0x400C28C")]
	[FieldOffset(Offset = "0x38")]
	private int m_GateType;

	[Token(Token = "0x400C28D")]
	[FieldOffset(Offset = "0x3C")]
	private int m_Index;

	[Token(Token = "0x400C28E")]
	private const string PLAYERPRESKEY_BIGAWARD_BUBBLE = "DigitaluniverseB_BigAward_Bubble_{0}_{1}";

	[Token(Token = "0x60096BD")]
	[Address(RVA = "0x2F81AF4", Offset = "0x2F81AF4", VA = "0x2F81AF4")]
	public UIDigitaluniverseBNormalAwardItemController()
	{
	}

	[Token(Token = "0x60096BE")]
	[Address(RVA = "0x2F81B78", Offset = "0x2F81B78", VA = "0x2F81B78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60096BF")]
	[Address(RVA = "0x2F81C20", Offset = "0x2F81C20", VA = "0x2F81C20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60096C0")]
	[Address(RVA = "0x2F794B8", Offset = "0x2F794B8", VA = "0x2F794B8")]
	public void SetData(DigitaluniverseBMissionRewardDesc data, int index, int gateType = 4)
	{
	}

	[Token(Token = "0x60096C1")]
	[Address(RVA = "0x2F81DEC", Offset = "0x2F81DEC", VA = "0x2F81DEC")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x60096C2")]
	[Address(RVA = "0x2F8243C", Offset = "0x2F8243C", VA = "0x2F8243C")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x60096C3")]
	[Address(RVA = "0x2F83238", Offset = "0x2F83238", VA = "0x2F83238")]
	public void ShowItem()
	{
	}

	[Token(Token = "0x60096C4")]
	[Address(RVA = "0x2F83930", Offset = "0x2F83930", VA = "0x2F83930")]
	public void SetCollectionRewardClickDelegate(UIButton rewardBtn)
	{
	}

	[Token(Token = "0x60096C5")]
	[Address(RVA = "0x2F83A54", Offset = "0x2F83A54", VA = "0x2F83A54")]
	public int GetAwardState()
	{
		return default(int);
	}

	[Token(Token = "0x60096C6")]
	[Address(RVA = "0x2F83B54", Offset = "0x2F83B54", VA = "0x2F83B54")]
	private void _003CSetCollectionRewardClickDelegate_003Em__0()
	{
	}

	[Token(Token = "0x60096C7")]
	[Address(RVA = "0x2F842F4", Offset = "0x2F842F4", VA = "0x2F842F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
