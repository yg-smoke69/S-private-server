using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002042")]
internal class UIHudCSFactionController : UIBaseController
{
	[Token(Token = "0x2002043")]
	private sealed class _003CSetODFaction_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CA48")]
		[FieldOffset(Offset = "0x8")]
		internal int localODFactionId;

		[Token(Token = "0x600A3FA")]
		[Address(RVA = "0x1F0727C", Offset = "0x1F0727C", VA = "0x1F0727C")]
		public _003CSetODFaction_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A3FB")]
		[Address(RVA = "0x1F08500", Offset = "0x1F08500", VA = "0x1F08500")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400CA3F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCSFactionView m_View;

	[Token(Token = "0x400CA40")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallId;

	[Token(Token = "0x400CA41")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCallIdShow;

	[Token(Token = "0x400CA42")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsSetSelfTeamInfo;

	[Token(Token = "0x400CA43")]
	[FieldOffset(Offset = "0x35")]
	private bool m_IsSetOppoTeamInfo;

	[Token(Token = "0x400CA44")]
	[FieldOffset(Offset = "0x38")]
	private int m_LocalPlayerTeamId;

	[Token(Token = "0x400CA45")]
	[FieldOffset(Offset = "0x3C")]
	private bool mLocalPlayerJoined;

	[Token(Token = "0x400CA46")]
	[FieldOffset(Offset = "0x3D")]
	private bool mLoadingMaskClosed;

	[Token(Token = "0x400CA47")]
	[FieldOffset(Offset = "0x3E")]
	private bool mCupMatchIntroFinish;

	[Token(Token = "0x600A3E7")]
	[Address(RVA = "0x1F0512C", Offset = "0x1F0512C", VA = "0x1F0512C")]
	public UIHudCSFactionController()
	{
	}

	[Token(Token = "0x600A3E8")]
	[Address(RVA = "0x1F051B0", Offset = "0x1F051B0", VA = "0x1F051B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A3E9")]
	[Address(RVA = "0x1F05258", Offset = "0x1F05258", VA = "0x1F05258", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A3EA")]
	[Address(RVA = "0x1F0572C", Offset = "0x1F0572C", VA = "0x1F0572C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A3EB")]
	[Address(RVA = "0x1F05B48", Offset = "0x1F05B48", VA = "0x1F05B48")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600A3EC")]
	[Address(RVA = "0x1F0673C", Offset = "0x1F0673C", VA = "0x1F0673C")]
	private void SetODFaction(int localODFactionId, bool updateByFactionChange)
	{
	}

	[Token(Token = "0x600A3ED")]
	[Address(RVA = "0x1F07030", Offset = "0x1F07030", VA = "0x1F07030")]
	private bool IsFactionChangeRound()
	{
		return default(bool);
	}

	[Token(Token = "0x600A3EE")]
	[Address(RVA = "0x1F07284", Offset = "0x1F07284", VA = "0x1F07284")]
	private void OnODFactionChanged(object[] data)
	{
	}

	[Token(Token = "0x600A3EF")]
	[Address(RVA = "0x1F074AC", Offset = "0x1F074AC", VA = "0x1F074AC")]
	private void OnLocalPlayerJoin(object[] data)
	{
	}

	[Token(Token = "0x600A3F0")]
	[Address(RVA = "0x1F079E0", Offset = "0x1F079E0", VA = "0x1F079E0")]
	private void OnPlayerJoin(object[] data)
	{
	}

	[Token(Token = "0x600A3F1")]
	[Address(RVA = "0x1F07F28", Offset = "0x1F07F28", VA = "0x1F07F28")]
	private void OnLoadingMaskClosed(object[] data)
	{
	}

	[Token(Token = "0x600A3F2")]
	[Address(RVA = "0x1F07F98", Offset = "0x1F07F98", VA = "0x1F07F98")]
	private void OnCupMatchIntroFinish(object[] data)
	{
	}

	[Token(Token = "0x600A3F3")]
	[Address(RVA = "0x1F07614", Offset = "0x1F07614", VA = "0x1F07614")]
	private void CheckStartDelayShow()
	{
	}

	[Token(Token = "0x600A3F4")]
	[Address(RVA = "0x1F08008", Offset = "0x1F08008", VA = "0x1F08008")]
	private void OnPhaseChanged(object[] data)
	{
	}

	[Token(Token = "0x600A3F5")]
	[Address(RVA = "0x1F081A4", Offset = "0x1F081A4", VA = "0x1F081A4")]
	private void OnODFactionSwitchDone(object[] data)
	{
	}

	[Token(Token = "0x600A3F6")]
	[Address(RVA = "0x1F08330", Offset = "0x1F08330", VA = "0x1F08330")]
	private void ShowAndPlaySound()
	{
	}

	[Token(Token = "0x600A3F7")]
	[Address(RVA = "0x1F07E64", Offset = "0x1F07E64", VA = "0x1F07E64")]
	private bool IsTeamOnLeft(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600A3F8")]
	[Address(RVA = "0x1F084F0", Offset = "0x1F084F0", VA = "0x1F084F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A3F9")]
	[Address(RVA = "0x1F084F8", Offset = "0x1F084F8", VA = "0x1F084F8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
