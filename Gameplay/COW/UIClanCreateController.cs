using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200253D")]
public class UIClanCreateController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x200253E")]
	public enum TokenType
	{
		[Token(Token = "0x400E6CC")]
		Gold = 1,
		[Token(Token = "0x400E6CD")]
		Diamond,
		[Token(Token = "0x400E6CE")]
		Max
	}

	[Token(Token = "0x400E6BF")]
	private const int CREATE_CLAN_NAME_LOWER_LIMIT = 3;

	[Token(Token = "0x400E6C0")]
	private const int CREATE_CLAN_SLOGAN_LOWER_LIMIT = 3;

	[Token(Token = "0x400E6C1")]
	[FieldOffset(Offset = "0x48")]
	private uint goldNeeded;

	[Token(Token = "0x400E6C2")]
	[FieldOffset(Offset = "0x4C")]
	private uint goldOwned;

	[Token(Token = "0x400E6C3")]
	[FieldOffset(Offset = "0x50")]
	private uint diamonNeeded;

	[Token(Token = "0x400E6C4")]
	[FieldOffset(Offset = "0x54")]
	private int diamondOwned;

	[Token(Token = "0x400E6C5")]
	[FieldOffset(Offset = "0x58")]
	private TokenType m_CurrentTokenType;

	[Token(Token = "0x400E6C6")]
	[FieldOffset(Offset = "0x5C")]
	private UIClanCreateView m_View;

	[Token(Token = "0x400E6C7")]
	[FieldOffset(Offset = "0x60")]
	private List<string> m_TagIDs;

	[Token(Token = "0x400E6C8")]
	[FieldOffset(Offset = "0x64")]
	private List<string> m_AreaIDs;

	[Token(Token = "0x400E6C9")]
	[FieldOffset(Offset = "0x68")]
	private uint m_RankCondition;

	[Token(Token = "0x400E6CA")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_LevelCondition;

	[Token(Token = "0x600D8AF")]
	[Address(RVA = "0x2F30358", Offset = "0x2F30358", VA = "0x2F30358")]
	public UIClanCreateController()
	{
	}

	[Token(Token = "0x600D8B0")]
	[Address(RVA = "0x2F30368", Offset = "0x2F30368", VA = "0x2F30368")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D8B1")]
	[Address(RVA = "0x2F3040C", Offset = "0x2F3040C", VA = "0x2F3040C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D8B2")]
	[Address(RVA = "0x2F31184", Offset = "0x2F31184", VA = "0x2F31184", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D8B3")]
	[Address(RVA = "0x2F312B4", Offset = "0x2F312B4", VA = "0x2F312B4")]
	private void OnCoinBtnClick()
	{
	}

	[Token(Token = "0x600D8B4")]
	[Address(RVA = "0x2F3207C", Offset = "0x2F3207C", VA = "0x2F3207C")]
	private void OnGemBtnClick()
	{
	}

	[Token(Token = "0x600D8B5")]
	[Address(RVA = "0x2F321F4", Offset = "0x2F321F4", VA = "0x2F321F4")]
	private void OnChangeAudit()
	{
	}

	[Token(Token = "0x600D8B6")]
	[Address(RVA = "0x2F322DC", Offset = "0x2F322DC", VA = "0x2F322DC")]
	private void RefreshDefault()
	{
	}

	[Token(Token = "0x600D8B7")]
	[Address(RVA = "0x2F3249C", Offset = "0x2F3249C", VA = "0x2F3249C")]
	private void OnClickApprovalCondLevel()
	{
	}

	[Token(Token = "0x600D8B8")]
	[Address(RVA = "0x2F327A8", Offset = "0x2F327A8", VA = "0x2F327A8")]
	private void OnClickApprovalCondRank()
	{
	}

	[Token(Token = "0x600D8B9")]
	[Address(RVA = "0x2F32AB4", Offset = "0x2F32AB4", VA = "0x2F32AB4")]
	private void OnClickArea()
	{
	}

	[Token(Token = "0x600D8BA")]
	[Address(RVA = "0x2F32D40", Offset = "0x2F32D40", VA = "0x2F32D40")]
	private void OnClickTag()
	{
	}

	[Token(Token = "0x600D8BB")]
	[Address(RVA = "0x2F3142C", Offset = "0x2F3142C", VA = "0x2F3142C")]
	private void OnBtnConfirmClick()
	{
	}

	[Token(Token = "0x600D8BC")]
	[Address(RVA = "0x2F32FCC", Offset = "0x2F32FCC", VA = "0x2F32FCC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D8BD")]
	[Address(RVA = "0x2F3309C", Offset = "0x2F3309C", VA = "0x2F3309C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D8BE")]
	[Address(RVA = "0x2F30EEC", Offset = "0x2F30EEC", VA = "0x2F30EEC")]
	private void RefreshPriceBtnState(int coinCost, int ownedCoin, int gemCost, int ownedGem)
	{
	}

	[Token(Token = "0x600D8BF")]
	[Address(RVA = "0x2F33130", Offset = "0x2F33130", VA = "0x2F33130")]
	private void _003COnClickApprovalCondLevel_003Em__0(List<string> ids)
	{
	}

	[Token(Token = "0x600D8C0")]
	[Address(RVA = "0x2F33300", Offset = "0x2F33300", VA = "0x2F33300")]
	private void _003COnClickApprovalCondRank_003Em__1(List<string> ids)
	{
	}

	[Token(Token = "0x600D8C1")]
	[Address(RVA = "0x2F334D0", Offset = "0x2F334D0", VA = "0x2F334D0")]
	private void _003COnClickArea_003Em__2(List<string> ids)
	{
	}

	[Token(Token = "0x600D8C2")]
	[Address(RVA = "0x2F335C4", Offset = "0x2F335C4", VA = "0x2F335C4")]
	private void _003COnClickTag_003Em__3(List<string> ids)
	{
	}

	[Token(Token = "0x600D8C3")]
	[Address(RVA = "0x2F336B8", Offset = "0x2F336B8", VA = "0x2F336B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D8C4")]
	[Address(RVA = "0x2F336C0", Offset = "0x2F336C0", VA = "0x2F336C0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
