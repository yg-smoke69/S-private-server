using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002804")]
internal class UIHudPlayerRemainingInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F6F2")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPlayerRemainingInfoView m_View;

	[Token(Token = "0x400F6F3")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_MatchModel;

	[Token(Token = "0x400F6F4")]
	[FieldOffset(Offset = "0x30")]
	private bool m_ShowKda;

	[Token(Token = "0x400F6F5")]
	[FieldOffset(Offset = "0x34")]
	private InfoStyle m_InfoStyle;

	[Token(Token = "0x400F6F6")]
	[FieldOffset(Offset = "0x38")]
	private int m_AliveCount;

	[Token(Token = "0x600F8C0")]
	[Address(RVA = "0x18672B0", Offset = "0x18672B0", VA = "0x18672B0")]
	public UIHudPlayerRemainingInfoController()
	{
	}

	[Token(Token = "0x600F8C1")]
	[Address(RVA = "0x1867334", Offset = "0x1867334", VA = "0x1867334")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F8C2")]
	[Address(RVA = "0x18673D8", Offset = "0x18673D8", VA = "0x18673D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F8C3")]
	[Address(RVA = "0x18681B8", Offset = "0x18681B8", VA = "0x18681B8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F8C4")]
	[Address(RVA = "0x1867968", Offset = "0x1867968", VA = "0x1867968")]
	private void HideObject()
	{
	}

	[Token(Token = "0x600F8C5")]
	[Address(RVA = "0x186841C", Offset = "0x186841C", VA = "0x186841C")]
	protected void OnGuildWarItemChange(object[] param)
	{
	}

	[Token(Token = "0x600F8C6")]
	[Address(RVA = "0x1867B80", Offset = "0x1867B80", VA = "0x1867B80")]
	private void ResetCntLabel()
	{
	}

	[Token(Token = "0x600F8C7")]
	[Address(RVA = "0x18686E4", Offset = "0x18686E4", VA = "0x18686E4")]
	public void OnHideTheUIView(object[] param)
	{
	}

	[Token(Token = "0x600F8C8")]
	[Address(RVA = "0x18687D0", Offset = "0x18687D0", VA = "0x18687D0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F8C9")]
	[Address(RVA = "0x1868F84", Offset = "0x1868F84", VA = "0x1868F84", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F8CA")]
	[Address(RVA = "0x18690B0", Offset = "0x18690B0", VA = "0x18690B0")]
	private void OnTrainingZonePlayerCntChange(object[] data)
	{
	}

	[Token(Token = "0x600F8CB")]
	[Address(RVA = "0x1867DF0", Offset = "0x1867DF0", VA = "0x1867DF0")]
	public void InitGameModeStyle()
	{
	}

	[Token(Token = "0x600F8CC")]
	[Address(RVA = "0x1869368", Offset = "0x1869368", VA = "0x1869368")]
	public void RefreshInfoStyle(InfoStyle infoType)
	{
	}

	[Token(Token = "0x600F8CD")]
	[Address(RVA = "0x18696B4", Offset = "0x18696B4", VA = "0x18696B4")]
	public void SetRemainLabel(string transfer)
	{
	}

	[Token(Token = "0x600F8CE")]
	[Address(RVA = "0x186961C", Offset = "0x186961C", VA = "0x186961C")]
	private void SetScoreText(string transfer)
	{
	}

	[Token(Token = "0x600F8CF")]
	[Address(RVA = "0x1868D14", Offset = "0x1868D14", VA = "0x1868D14")]
	private void UpdateKillCnt(int cnt)
	{
	}

	[Token(Token = "0x600F8D0")]
	[Address(RVA = "0x1868E80", Offset = "0x1868E80", VA = "0x1868E80")]
	private void UpdateKDACnt(float cnt)
	{
	}

	[Token(Token = "0x600F8D1")]
	[Address(RVA = "0x1868AF0", Offset = "0x1868AF0", VA = "0x1868AF0")]
	private void UpdateAliveCnt(int cnt)
	{
	}

	[Token(Token = "0x600F8D2")]
	[Address(RVA = "0x1868C5C", Offset = "0x1868C5C", VA = "0x1868C5C")]
	private void UpdateEnemyCnt(int cnt)
	{
	}

	[Token(Token = "0x600F8D3")]
	[Address(RVA = "0x1869758", Offset = "0x1869758", VA = "0x1869758")]
	private void ShowTutorial(object[] data)
	{
	}

	[Token(Token = "0x600F8D4")]
	[Address(RVA = "0x1869894", Offset = "0x1869894", VA = "0x1869894")]
	private void OnSettingNoHudNotify(object[] data)
	{
	}

	[Token(Token = "0x600F8D5")]
	[Address(RVA = "0x1869900", Offset = "0x1869900", VA = "0x1869900")]
	private void OnScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600F8D6")]
	[Address(RVA = "0x1869B48", Offset = "0x1869B48", VA = "0x1869B48")]
	private void OnShowFateRandomGuide(object[] data)
	{
	}

	[Token(Token = "0x600F8D7")]
	[Address(RVA = "0x1869CB8", Offset = "0x1869CB8", VA = "0x1869CB8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F8D8")]
	[Address(RVA = "0x1869CC0", Offset = "0x1869CC0", VA = "0x1869CC0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
