using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x2003092")]
public class UIModelGameBonusEvent : UIBaseModel
{
	[Token(Token = "0x2003093")]
	private sealed class _003CIsInDoubleBonusPeriod_003Ec__AnonStorey0
	{
		[Token(Token = "0x401278C")]
		[FieldOffset(Offset = "0x8")]
		internal uint matchMode;

		[Token(Token = "0x401278D")]
		[FieldOffset(Offset = "0xC")]
		internal uint gameMode;

		[Token(Token = "0x401278E")]
		[FieldOffset(Offset = "0x10")]
		internal uint mapID;

		[Token(Token = "0x401278F")]
		[FieldOffset(Offset = "0x14")]
		internal HHDIPHFOBFO groupMode;

		[Token(Token = "0x4012790")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelGameBonusEvent _0024this;

		[Token(Token = "0x60144F7")]
		[Address(RVA = "0x31A7374", Offset = "0x31A7374", VA = "0x31A7374")]
		public _003CIsInDoubleBonusPeriod_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60144F8")]
		[Address(RVA = "0x31A86CC", Offset = "0x31A86CC", VA = "0x31A86CC")]
		internal bool _003C_003Em__0(GameBonusEventDesc e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012786")]
	[FieldOffset(Offset = "0xC")]
	private CSGetGameBonusEventDescRes m_Desc;

	[Token(Token = "0x4012787")]
	private const int AllGroupMode = -1;

	[Token(Token = "0x4012788")]
	private const int AllGameMode = 0;

	[Token(Token = "0x4012789")]
	private const int AllMatchMode = 0;

	[Token(Token = "0x401278A")]
	private const int AllMapID = 0;

	[Token(Token = "0x401278B")]
	public const int PropID_BonusEventDescRespond = 2;

	[Token(Token = "0x60144ED")]
	[Address(RVA = "0x31A6BE4", Offset = "0x31A6BE4", VA = "0x31A6BE4")]
	public UIModelGameBonusEvent()
	{
	}

	[Token(Token = "0x60144EE")]
	[Address(RVA = "0x31A6C68", Offset = "0x31A6C68", VA = "0x31A6C68", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60144EF")]
	[Address(RVA = "0x31A6CE0", Offset = "0x31A6CE0", VA = "0x31A6CE0")]
	public void ProcessDescData(CSGetGameBonusEventDescRes desc)
	{
	}

	[Token(Token = "0x60144F0")]
	[Address(RVA = "0x31A6D40", Offset = "0x31A6D40", VA = "0x31A6D40")]
	public void RequestGameBonusEventDesc(bool force = false)
	{
	}

	[Token(Token = "0x60144F1")]
	[Address(RVA = "0x31A6F6C", Offset = "0x31A6F6C", VA = "0x31A6F6C")]
	public bool IsInDoubleBonusPeriod(uint matchMode, uint gameMode, uint mapID, HHDIPHFOBFO groupMode, out GameBonusEventDesc eventDesc, out ulong startTime, out ulong endTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60144F2")]
	[Address(RVA = "0x31A737C", Offset = "0x31A737C", VA = "0x31A737C")]
	public bool IsConditionMatch(GameBonusEventDesc desc, uint matchMode, uint gameMode, uint mapID, HHDIPHFOBFO groupMode)
	{
		return default(bool);
	}

	[Token(Token = "0x60144F3")]
	[Address(RVA = "0x31A7498", Offset = "0x31A7498", VA = "0x31A7498", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60144F4")]
	[Address(RVA = "0x31A74F0", Offset = "0x31A74F0", VA = "0x31A74F0")]
	public string GetBonusEventInfo(MapModeData mapModeData, HHDIPHFOBFO groupMode, out List<ResourceID> spriteList)
	{
		return null;
	}

	[Token(Token = "0x60144F5")]
	[Address(RVA = "0x31A85E4", Offset = "0x31A85E4", VA = "0x31A85E4")]
	private void _003CRequestGameBonusEventDesc_003Em__0(HttpErrorCode err, object res)
	{
	}

	[Token(Token = "0x60144F6")]
	[Address(RVA = "0x31A86C4", Offset = "0x31A86C4", VA = "0x31A86C4")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
