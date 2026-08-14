using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200247E")]
internal class UIHUDUGC_TwoTeam_ShowTimeController : UIBaseController, _Attribute
{
	[Token(Token = "0x200247F")]
	private enum ShowTimeEnum
	{
		[Token(Token = "0x400E26D")]
		None,
		[Token(Token = "0x400E26E")]
		Victory,
		[Token(Token = "0x400E26F")]
		Defeated,
		[Token(Token = "0x400E270")]
		Draw,
		[Token(Token = "0x400E271")]
		Booyah
	}

	[Token(Token = "0x400E265")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_TwoTeam_ShowTimeView m_View;

	[Token(Token = "0x400E266")]
	[FieldOffset(Offset = "0x2C")]
	private RoundResultShowTimeHudEntity m_ViewData;

	[Token(Token = "0x400E267")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x400E268")]
	[FieldOffset(Offset = "0x34")]
	private int m_PhaseEndTime;

	[Token(Token = "0x400E269")]
	[FieldOffset(Offset = "0x38")]
	private int m_PhaseCountDown;

	[Token(Token = "0x400E26A")]
	[FieldOffset(Offset = "0x3C")]
	private int m_LastTime;

	[Token(Token = "0x400E26B")]
	[FieldOffset(Offset = "0x40")]
	private uint m_DelayReturnBtnEnableID;

	[Token(Token = "0x600D021")]
	[Address(RVA = "0x292E3E4", Offset = "0x292E3E4", VA = "0x292E3E4")]
	public UIHUDUGC_TwoTeam_ShowTimeController()
	{
	}

	[Token(Token = "0x600D022")]
	[Address(RVA = "0x292E468", Offset = "0x292E468", VA = "0x292E468")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D023")]
	[Address(RVA = "0x292E50C", Offset = "0x292E50C", VA = "0x292E50C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D024")]
	[Address(RVA = "0x292E7C0", Offset = "0x292E7C0", VA = "0x292E7C0", Slot = "24")]
	protected override void RefreshVisibility()
	{
	}

	[Token(Token = "0x600D025")]
	[Address(RVA = "0x292E938", Offset = "0x292E938", VA = "0x292E938", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D026")]
	[Address(RVA = "0x292EABC", Offset = "0x292EABC", VA = "0x292EABC")]
	private void UpdatePhaseCountDown()
	{
	}

	[Token(Token = "0x600D027")]
	[Address(RVA = "0x292EF24", Offset = "0x292EF24", VA = "0x292EF24")]
	private void Update()
	{
	}

	[Token(Token = "0x600D028")]
	[Address(RVA = "0x292EF90", Offset = "0x292EF90", VA = "0x292EF90")]
	private void OnReturnBtnClick()
	{
	}

	[Token(Token = "0x600D029")]
	[Address(RVA = "0x292F178", Offset = "0x292F178", VA = "0x292F178", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600D02A")]
	[Address(RVA = "0x292EA48", Offset = "0x292EA48", VA = "0x292EA48", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600D02B")]
	[Address(RVA = "0x292F464", Offset = "0x292F464", VA = "0x292F464")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D02C")]
	[Address(RVA = "0x292F5C4", Offset = "0x292F5C4", VA = "0x292F5C4")]
	private void OnShowTimeTypeChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D02D")]
	[Address(RVA = "0x292F73C", Offset = "0x292F73C", VA = "0x292F73C")]
	private void OnPhaseEndTimeChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D02E")]
	[Address(RVA = "0x292FAD8", Offset = "0x292FAD8", VA = "0x292FAD8")]
	private void OnShowTwoTeamScoreChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D02F")]
	[Address(RVA = "0x292FB88", Offset = "0x292FB88", VA = "0x292FB88")]
	private void OnLeftTeamScoreChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D030")]
	[Address(RVA = "0x292FC4C", Offset = "0x292FC4C", VA = "0x292FC4C")]
	private void OnRightTeamScoreChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D031")]
	[Address(RVA = "0x292FD10", Offset = "0x292FD10", VA = "0x292FD10")]
	private void _003CRefreshVisibility_003Em__0()
	{
	}

	[Token(Token = "0x600D032")]
	[Address(RVA = "0x292FD5C", Offset = "0x292FD5C", VA = "0x292FD5C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D033")]
	[Address(RVA = "0x292FD64", Offset = "0x292FD64", VA = "0x292FD64")]
	public void _003C_003EiFixBaseProxy_RefreshVisibility()
	{
	}

	[Token(Token = "0x600D034")]
	[Address(RVA = "0x292FD6C", Offset = "0x292FD6C", VA = "0x292FD6C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
