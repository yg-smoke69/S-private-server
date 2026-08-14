using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200228D")]
internal class UISPHudTeamAccStatsItemController : UIBaseController
{
	[Token(Token = "0x200228E")]
	private sealed class _003CUpdateReviveInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D872")]
		[FieldOffset(Offset = "0x8")]
		internal AccTeamData data;

		[Token(Token = "0x600BD87")]
		[Address(RVA = "0x149205C", Offset = "0x149205C", VA = "0x149205C")]
		public _003CUpdateReviveInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600BD88")]
		[Address(RVA = "0x1492450", Offset = "0x1492450", VA = "0x1492450")]
		internal bool _003C_003Em__0(TeamData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200228F")]
	private sealed class _003CSetLivecountData_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D873")]
		[FieldOffset(Offset = "0x8")]
		internal AccTeamData data;

		[Token(Token = "0x600BD89")]
		[Address(RVA = "0x1492064", Offset = "0x1492064", VA = "0x1492064")]
		public _003CSetLivecountData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600BD8A")]
		[Address(RVA = "0x1492404", Offset = "0x1492404", VA = "0x1492404")]
		internal bool _003C_003Em__0(TeamData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D86B")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudTeamAccStatsItemView m_View;

	[Token(Token = "0x400D86C")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400D86D")]
	[FieldOffset(Offset = "0x30")]
	private List<UISprite> m_ActivePlayIconList;

	[Token(Token = "0x400D86E")]
	[FieldOffset(Offset = "0x34")]
	private List<UISprite> m_DeadPlayerIconList;

	[Token(Token = "0x400D86F")]
	[FieldOffset(Offset = "0x38")]
	private UIModelSpectator m_MoedelSpectator;

	[Token(Token = "0x400D870")]
	[FieldOffset(Offset = "0x3C")]
	private SafeZone m_SafeZone;

	[Token(Token = "0x400D871")]
	[FieldOffset(Offset = "0x40")]
	private byte m_TeamId;

	[Token(Token = "0x600BD77")]
	[Address(RVA = "0x148F0D0", Offset = "0x148F0D0", VA = "0x148F0D0")]
	public UISPHudTeamAccStatsItemController()
	{
	}

	[Token(Token = "0x600BD78")]
	[Address(RVA = "0x148F1A0", Offset = "0x148F1A0", VA = "0x148F1A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BD79")]
	[Address(RVA = "0x148F248", Offset = "0x148F248", VA = "0x148F248", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BD7A")]
	[Address(RVA = "0x1490678", Offset = "0x1490678", VA = "0x1490678", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BD7B")]
	[Address(RVA = "0x149078C", Offset = "0x149078C", VA = "0x149078C")]
	public void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600BD7C")]
	[Address(RVA = "0x14916E8", Offset = "0x14916E8", VA = "0x14916E8")]
	public void SetUIData(AccTeamData data)
	{
	}

	[Token(Token = "0x600BD7D")]
	[Address(RVA = "0x1491758", Offset = "0x1491758", VA = "0x1491758")]
	public void SetPoisonSpecialEffects()
	{
	}

	[Token(Token = "0x600BD7E")]
	[Address(RVA = "0x1491B5C", Offset = "0x1491B5C", VA = "0x1491B5C")]
	public void UpdateReviveInfo(AccTeamData data)
	{
	}

	[Token(Token = "0x600BD7F")]
	[Address(RVA = "0x1490F64", Offset = "0x1490F64", VA = "0x1490F64")]
	public void SetLivecountData(AccTeamData data)
	{
	}

	[Token(Token = "0x600BD80")]
	[Address(RVA = "0x149206C", Offset = "0x149206C", VA = "0x149206C")]
	private string GetSpriteNameByNum(uint num)
	{
		return null;
	}

	[Token(Token = "0x600BD81")]
	[Address(RVA = "0x149217C", Offset = "0x149217C", VA = "0x149217C")]
	public void ShowKillerKing(byte teamId)
	{
	}

	[Token(Token = "0x600BD82")]
	[Address(RVA = "0x1492220", Offset = "0x1492220", VA = "0x1492220")]
	public void ShowTeamAce(byte id)
	{
	}

	[Token(Token = "0x600BD83")]
	[Address(RVA = "0x1492334", Offset = "0x1492334", VA = "0x1492334")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x600BD84")]
	[Address(RVA = "0x14923BC", Offset = "0x14923BC", VA = "0x14923BC")]
	private bool _003CSetPoisonSpecialEffects_003Em__1(TeamData a)
	{
		return default(bool);
	}

	[Token(Token = "0x600BD85")]
	[Address(RVA = "0x14923F4", Offset = "0x14923F4", VA = "0x14923F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BD86")]
	[Address(RVA = "0x14923FC", Offset = "0x14923FC", VA = "0x14923FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
