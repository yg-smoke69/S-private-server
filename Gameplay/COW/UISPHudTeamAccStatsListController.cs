using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002290")]
internal class UISPHudTeamAccStatsListController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002291")]
	public enum EInputType
	{
		[Token(Token = "0x400D882")]
		KeycodeCall,
		[Token(Token = "0x400D883")]
		KeycodeFSwitch
	}

	[Token(Token = "0x400D874")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudTeamAccStatsListView m_View;

	[Token(Token = "0x400D875")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelSpectator m_Model;

	[Token(Token = "0x400D876")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsShowing;

	[Token(Token = "0x400D877")]
	[FieldOffset(Offset = "0x34")]
	private List<UISPHudTeamAccStatsItemController> m_TeamCtrlList;

	[Token(Token = "0x400D878")]
	[FieldOffset(Offset = "0x38")]
	private EInfoType m_PrevType;

	[Token(Token = "0x400D879")]
	[FieldOffset(Offset = "0x3C")]
	private EInfoType m_InfoType;

	[Token(Token = "0x400D87A")]
	[FieldOffset(Offset = "0x40")]
	private EInputType m_InputType;

	[Token(Token = "0x400D87B")]
	[FieldOffset(Offset = "0x44")]
	private float m_CachedY;

	[Token(Token = "0x400D87C")]
	private const int NoneX = -355;

	[Token(Token = "0x400D87D")]
	private const int NormalX = -597;

	[Token(Token = "0x400D87E")]
	private const int ExtendX = -639;

	[Token(Token = "0x400D87F")]
	[FieldOffset(Offset = "0x48")]
	private float m_TimeElapsed;

	[Token(Token = "0x400D880")]
	[FieldOffset(Offset = "0x4C")]
	private byte m_KoKTeamId;

	[Token(Token = "0x600BD8B")]
	[Address(RVA = "0x14930E0", Offset = "0x14930E0", VA = "0x14930E0")]
	public UISPHudTeamAccStatsListController()
	{
	}

	[Token(Token = "0x600BD8C")]
	[Address(RVA = "0x1493198", Offset = "0x1493198", VA = "0x1493198")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BD8D")]
	[Address(RVA = "0x1493240", Offset = "0x1493240", VA = "0x1493240", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BD8E")]
	[Address(RVA = "0x1493560", Offset = "0x1493560", VA = "0x1493560", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BD8F")]
	[Address(RVA = "0x1493788", Offset = "0x1493788", VA = "0x1493788")]
	private void OnTogglePanel(object[] data)
	{
	}

	[Token(Token = "0x600BD90")]
	[Address(RVA = "0x1493FB4", Offset = "0x1493FB4", VA = "0x1493FB4")]
	private void OnShowKillerKing(object[] data)
	{
	}

	[Token(Token = "0x600BD91")]
	[Address(RVA = "0x14941B0", Offset = "0x14941B0", VA = "0x14941B0")]
	private void OnShowTeamAce(object[] data)
	{
	}

	[Token(Token = "0x600BD92")]
	[Address(RVA = "0x14943B4", Offset = "0x14943B4", VA = "0x14943B4")]
	private void OnUIToggle(object[] data)
	{
	}

	[Token(Token = "0x600BD93")]
	[Address(RVA = "0x1494464", Offset = "0x1494464", VA = "0x1494464")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600BD94")]
	[Address(RVA = "0x149477C", Offset = "0x149477C", VA = "0x149477C")]
	private void Update()
	{
	}

	[Token(Token = "0x600BD95")]
	[Address(RVA = "0x1494818", Offset = "0x1494818", VA = "0x1494818")]
	private void RefreshPoisonSpecialEffects()
	{
	}

	[Token(Token = "0x600BD96")]
	[Address(RVA = "0x14949B8", Offset = "0x14949B8", VA = "0x14949B8")]
	private void RefreshLivecountUI()
	{
	}

	[Token(Token = "0x600BD97")]
	[Address(RVA = "0x1494BD4", Offset = "0x1494BD4", VA = "0x1494BD4")]
	private void RefreshReviveUI()
	{
	}

	[Token(Token = "0x600BD98")]
	[Address(RVA = "0x1494DB4", Offset = "0x1494DB4", VA = "0x1494DB4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BD99")]
	[Address(RVA = "0x1494EA0", Offset = "0x1494EA0", VA = "0x1494EA0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BD9A")]
	[Address(RVA = "0x1494F34", Offset = "0x1494F34", VA = "0x1494F34")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BD9B")]
	[Address(RVA = "0x1494F3C", Offset = "0x1494F3C", VA = "0x1494F3C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
