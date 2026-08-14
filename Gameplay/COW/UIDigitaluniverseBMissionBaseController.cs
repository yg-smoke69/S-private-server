using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EE2")]
public class UIDigitaluniverseBMissionBaseController : UIBaseController
{
	[Token(Token = "0x400C277")]
	[FieldOffset(Offset = "0x28")]
	protected UIDigitaluniverseBMissionBaseItemView m_View;

	[Token(Token = "0x400C278")]
	[FieldOffset(Offset = "0x2C")]
	protected int m_tabIndex;

	[Token(Token = "0x400C279")]
	[FieldOffset(Offset = "0x30")]
	protected int m_missionIndex;

	[Token(Token = "0x400C27A")]
	[FieldOffset(Offset = "0x34")]
	private uint m_ActivityID;

	[Token(Token = "0x400C27B")]
	[FieldOffset(Offset = "0x38")]
	private int m_type;

	[Token(Token = "0x400C27C")]
	[FieldOffset(Offset = "0x3C")]
	private ClientActivityDesc m_ActivityDesc;

	[Token(Token = "0x400C27D")]
	private const string MISSION_AWARD_PROGRESS_FORMAT = "{0}/{1}";

	[Token(Token = "0x400C27E")]
	[FieldOffset(Offset = "0x40")]
	protected EActivity.State m_State;

	[Token(Token = "0x400C27F")]
	[FieldOffset(Offset = "0x44")]
	private readonly List<UIStandardItemMiniController> m_ItemList;

	[Token(Token = "0x60096A4")]
	[Address(RVA = "0x2F7EAE8", Offset = "0x2F7EAE8", VA = "0x2F7EAE8")]
	public UIDigitaluniverseBMissionBaseController()
	{
	}

	[Token(Token = "0x60096A5")]
	[Address(RVA = "0x2F7EBA0", Offset = "0x2F7EBA0", VA = "0x2F7EBA0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60096A6")]
	[Address(RVA = "0x2F7EF58", Offset = "0x2F7EF58", VA = "0x2F7EF58", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60096A7")]
	[Address(RVA = "0x2F7EFBC", Offset = "0x2F7EFBC", VA = "0x2F7EFBC")]
	public void SetViewData(ClientActivityDesc activityDesc, int tabIndex, int missionIndex, int type)
	{
	}

	[Token(Token = "0x60096A8")]
	[Address(RVA = "0x2F7F6F0", Offset = "0x2F7F6F0", VA = "0x2F7F6F0")]
	public void RefreshViewData()
	{
	}

	[Token(Token = "0x60096A9")]
	[Address(RVA = "0x2F7ECFC", Offset = "0x2F7ECFC", VA = "0x2F7ECFC")]
	private void SetupDefaultStateOnInit()
	{
	}

	[Token(Token = "0x60096AA")]
	[Address(RVA = "0x2F7FAEC", Offset = "0x2F7FAEC", VA = "0x2F7FAEC")]
	private bool SetMissionStateLock(EActivity.State state)
	{
		return default(bool);
	}

	[Token(Token = "0x60096AB")]
	[Address(RVA = "0x2F7FF68", Offset = "0x2F7FF68", VA = "0x2F7FF68", Slot = "31")]
	protected virtual void SetMaskState()
	{
	}

	[Token(Token = "0x60096AC")]
	[Address(RVA = "0x2F7FFBC", Offset = "0x2F7FFBC", VA = "0x2F7FFBC", Slot = "32")]
	protected virtual void OnClaimAward()
	{
	}

	[Token(Token = "0x60096AD")]
	[Address(RVA = "0x2F7FC5C", Offset = "0x2F7FC5C", VA = "0x2F7FC5C")]
	public void SetMissionStateLock()
	{
	}

	[Token(Token = "0x60096AE")]
	[Address(RVA = "0x2F80188", Offset = "0x2F80188", VA = "0x2F80188")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60096AF")]
	[Address(RVA = "0x2F80190", Offset = "0x2F80190", VA = "0x2F80190")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
